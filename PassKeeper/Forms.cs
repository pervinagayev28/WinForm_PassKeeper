using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper
{
    static class Forms
    {
        static public form_sign_in? FSignIn = new();
        static public ForgetPasswordSendCode? FForgetPassSendCode = new();
        static public  ForgotPassActivateCode? forgotPassActivateCode = new();
        static public   CreatNewPass? CreatNewPass = new();
        static public   CreatNewPassSuccsessed? CreatNewPassSuccsessed = new();
        static public   Register ? register = new();
        static public   RegistrPassword ? registrPassword = new();
        static public   LandingProfile ? landingProfile = new();

        public static void closeAllForms()
        {
            FSignIn.Close();
            FForgetPassSendCode.Close();
            forgotPassActivateCode.Close();
            CreatNewPass.Close();
            CreatNewPassSuccsessed.Close();
            register.Close();
            registrPassword.Close();
            landingProfile.Close();
        }
    }
}
