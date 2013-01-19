﻿using System;

namespace PAE.WebUI
{
    public partial class Default : BasePage
    {
        #region Constants

        public const string LANGUAGE_URL_FORMAT = @"~/{0}";

        #endregion

        #region Properties

        public override string LanguageUrlFormat
        {
            get { return LANGUAGE_URL_FORMAT; }
        }

        #endregion

        #region Event Handlers

        protected void ExpressModeLink_Click(object sender, EventArgs e)
        {
            string url = string.Format(Express.LANGUAGE_URL_FORMAT, this.SelectedLanguage);
            this.Response.Redirect(url);
        }

        #endregion
    }
}
