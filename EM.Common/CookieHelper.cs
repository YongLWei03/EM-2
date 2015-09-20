﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;

namespace EMTop.Common
{
    public class CookieHelper
    {
        public CookieHelper()
        {
            //
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_CookieName"></param>
        /// <param name="p_CookieObject"></param>
        /// <param name="p_Expires"></param>
        public static void SetObjectCookie(string p_CookieName, Object p_CookieObject, DateTime? p_Expires)
        {
            HttpCookie cookie;
            if (HttpContext.Current.Request.Cookies[p_CookieName] != null)
            {
                cookie = HttpContext.Current.Request.Cookies[p_CookieName];
            }
            else
            {
                cookie = new HttpCookie(p_CookieName);
            }
            string cookieValue = Utils.ObjectStrConvert.ObjectToBase64Str(p_CookieObject);
            cookie.Values.Add("ObjectKey", cookieValue);
            if (p_Expires.HasValue)
            {
                cookie.Expires = p_Expires.Value;
            }
            else
            {
                cookie.Expires = DateTime.MaxValue;
            }
            if (HttpContext.Current.Request.Cookies[p_CookieName] != null)
            {
                HttpContext.Current.Response.Cookies.Set(cookie);
            }
            else
            {
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
        }

        /// <summary>
        /// 得到指定Cookie项中保存的对象列表
        /// </summary>
        /// <param name="p_CookieName">Cookie项名字</param>
        /// <param name="ItemObjType">子项对象类型</param>
        /// <returns></returns>
        public static T GetObjectFromCookie<T>(string p_CookieName)
        {
            HttpCookie cookie;
            if (HttpContext.Current.Request.Cookies[p_CookieName] != null)
            {
                cookie = HttpContext.Current.Request.Cookies[p_CookieName];
                return (T)Utils.ObjectStrConvert.Base64StrToObject(cookie.Values["ObjectKey"], typeof(T));
            }
            return default(T);
        }

        /// <summary>
        /// 清除指定Cookie的所有子项
        /// </summary>
        /// <param name="p_CookieName">Cookie名字</param>
        public static void ClearCookieItems(string p_CookieName)
        {
            if (HttpContext.Current.Request.Cookies[p_CookieName] != null)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[p_CookieName];
                cookie.Values.Clear();
                HttpContext.Current.Response.Cookies.Set(cookie);
            }
        }

        ///<summary>
        /// Write cookie value
        /// </summary>
        /// <param name="strName">cookie name</param>
        /// <param name="strValue">cookie value</param>
        public static void WriteCookie(string cookieName, string cookieValue, bool rememberMe, int expiresDays=3)
        {
            if (string.IsNullOrEmpty(cookieName)) return;
            //删除旧的同名Cookie
            HttpContext.Current.Response.Cookies.Remove(cookieName);
            var cookie = new HttpCookie(cookieName);

            string ConfigVersion = ConfigurationManager.AppSettings["ConfigVersion"];
            if (ConfigVersion == "Release") {
                cookie.Domain = ".zheyibu.com";
                cookie.Secure = false;
            }
            else if (ConfigVersion == "Debug")
            {
                cookie.Domain = ".test.com";
                cookie.Secure = false;
            }
            else if (ConfigVersion == "Test")
            {
                cookie.Domain = ".beta.com";
                cookie.Secure = false;
            }

            cookie.Value = HttpUtility.UrlEncode(cookieValue, Encoding.GetEncoding("UTF-8"));
            if (rememberMe)
            {
                if (expiresDays == 0)
                    expiresDays = 365; //Remember me forever
                cookie.Expires = DateTime.Now.AddDays(expiresDays);
            }
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// Read cookie
        /// </summary>
        /// <param name="strName">cookie name</param>
        /// <returns>cookie value</returns>
        public static string GetCookie(string cookieName)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[cookieName] != null)
            {
                return HttpUtility.UrlDecode(HttpContext.Current.Request.Cookies[cookieName].Value.ToString(), Encoding.GetEncoding("UTF-8"));
            }
            return string.Empty;
        }

        /// <summary>
        /// Cookies
        /// </summary>
        /// <param name="strName">cookie name</param>
        public static void DeleteCookie(string strName)
        {
            if (HttpContext.Current.Request.Cookies[strName] != null)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
                cookie.Values.Clear();
                cookie.Expires = DateTime.Now.AddDays(-1);

                string ConfigVersion = ConfigurationManager.AppSettings["ConfigVersion"];
                if (ConfigVersion == "Release")
                {
                    cookie.Domain = ".zheyibu.com";
                    cookie.Secure = false;
                }
                if (ConfigVersion == "Debug")
                {
                    cookie.Domain = ".test.com";
                    cookie.Secure = false;
                }
                if (ConfigVersion == "Test")
                {
                    cookie.Domain = ".beta.com";
                    cookie.Secure = false;
                }

                HttpContext.Current.Response.Cookies.Set(cookie);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cookieName">名称</param>
        /// <param name="cookieValue">值</param>
        /// <param name="expires">过期时间</param>
        public static void WriteCookie(string cookieName, string cookieValue, DateTime? expires)
        {
            HttpCookie cookie;
            if (HttpContext.Current.Request.Cookies[cookieName] != null)
            {
                cookie = HttpContext.Current.Request.Cookies[cookieName];
            }
            else
            {
                cookie = new HttpCookie(cookieName);
            }

            string ConfigVersion = ConfigurationManager.AppSettings["ConfigVersion"];
            if (ConfigVersion == "Release")
            {
                cookie.Domain = ".zheyibu.com";
                cookie.Secure = false;
            }
            if (ConfigVersion == "Debug")
            {
                cookie.Domain = ".test.com";
                cookie.Secure = false;
            }
            if (ConfigVersion == "Test")
            {
                cookie.Domain = ".beta.com";
                cookie.Secure = false;
            }

            cookie.Value = HttpUtility.UrlEncode(cookieValue, Encoding.GetEncoding("UTF-8"));

            if (expires.HasValue)
            {
                cookie.Expires = expires.Value;
            }
            else
            {
                cookie.Expires = DateTime.MaxValue;
            }
            if (HttpContext.Current.Request.Cookies[cookieName] != null)
            {
                HttpContext.Current.Response.Cookies.Set(cookie);
            }
            else
            {
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
        }
    }
}