﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicBeach.Util.Data
{
    /// <summary>
    /// contact data type
    /// </summary>
    public struct Contact
    {
        #region constructor

        /// <summary>
        /// instance a Contact object
        /// </summary>
        /// <param name="phone">phone</param>
        /// <param name="mobile">mobile</param>
        /// <param name="email">email</param>
        /// <param name="qq">qq</param>
        /// <param name="msn">msn</param>
        /// <param name="weChat">weChat</param>
        /// <param name="weiBo">weiBo</param>
        public Contact(string phone = "", string mobile = "", string email = "", string qq = "", string msn = "", string weChat = "", string weiBo = "")
        {
            Phone = phone;
            Mobile = mobile;
            Email = email;
            QQ = qq;
            MSN = msn;
            WeChat = weChat;
            WeiBo = weiBo;
        }

        #endregion

        #region Propertys

        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// Mobile
        /// </summary>
        public string Mobile { get; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// QQ
        /// </summary>
        public string QQ { get; }

        /// <summary>
        /// MSN
        /// </summary>
        public string MSN { get; }

        /// <summary>
        /// WeChat
        /// </summary>
        public string WeChat { get; }

        /// <summary>
        /// WeiBo
        /// </summary>
        public string WeiBo { get; }

        #endregion

        #region static methods

        /// <summary>
        /// compare two contact objects whether is equal
        /// </summary>
        /// <param name="contactOne">first contact</param>
        /// <param name="contactTwo">second contact</param>
        /// <returns>whether is equal</returns>
        public static bool Equals(Contact contactOne, Contact contactTwo)
        {
            return contactOne.Email == contactTwo.Email &&
                contactOne.Mobile == contactTwo.Mobile &&
                contactOne.MSN == contactTwo.MSN &&
                contactOne.Phone == contactTwo.Phone &&
                contactOne.QQ == contactTwo.QQ &&
                contactOne.WeChat == contactTwo.WeChat &&
                contactOne.WeiBo == contactTwo.WeiBo;

        }

        #endregion

        #region methods

        /// <summary>
        /// override equals method
        /// </summary>
        /// <param name="obj">compare object</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Equals(this, (Contact)obj);
        }
        public override int GetHashCode()
        {
            return 0;
        }

        #endregion
    }
}
