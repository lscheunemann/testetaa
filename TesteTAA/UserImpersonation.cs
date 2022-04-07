using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;


namespace TesteTAA
{
    internal class UserImpersonation
    {
        private string domain;
        private string login;
        private string password;

        public UserImpersonation(string login, string domain, string password)
        {
            this.login = login;
            this.domain = domain;
            this.password = password;
        }

        internal bool ImpersonateValidUser()
        {
            throw new NotImplementedException();
        }
    }
}