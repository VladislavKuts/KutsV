using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class MainPageFB : SeleniumWrapper
    {
        //Authorization Form Fields
        internal static By Auth_EmailOrPhoneNumberField = By.Id("email");
        internal static By Auth_PasswordField = By.Id("password");
        //Сonfirm Button to authorization
        internal static By Auth_BtnSubmit = By.CssSelector("#u_0_2");

        //Registration Form Fields
        internal static By Reg_FirstNameField = By.Id("u_0_j");
        internal static By Reg_LastNameField = By.Id("u_0_l");
        internal static By Reg_PhoneNumberOrEmailField = By.Id("u_0_o");
        internal static By Reg_PasswordField = By.Id("u_0_v");
        //ListBox for change date of birthday on Registration Form 
        internal static By Reg_BithDay = By.CssSelector("#day > option:nth-child(9)");
        internal static By Reg_BithMounth = By.CssSelector("#month > option:nth-child(13)");
        internal static By Reg_BithYear = By.CssSelector("#year > option:nth-child(28)");
        //Button for change gender on Registration Form
        internal static By Reg_GenderFemale = By.Id("u_0_9");
        internal static By Reg_GenderMale = By.Id("u_0_a");
        //Сonfirm Button to register a new user
        internal static By Reg_BtnSubmit = By.CssSelector("#u_0_11");

        /// <summary>
        /// This method open Registration page of MyAccount.
        /// </summary>
        /// <returns></returns>
        public MainPageFB OpenRegistrationPage()
        {
            OpenPage("https://www.facebook.com/");
            return this;
        }

        /// <summary>
        /// This method fill text in Email field for user authorization.
        /// </summary>
        /// <param name="auth_emailorphonenumber"></param>
        /// <returns></returns>
        public MainPageFB Auth_FillEmailField(string auth_emailorphonenumber)
        {
            FindElement(Auth_EmailOrPhoneNumberField).SendKeys(auth_emailorphonenumber);
            return this;
        }

        /// <summary>
        /// This method fill text in Password field for user authorization.
        /// </summary>
        /// <param name="auth_password"></param>
        /// <returns></returns>
        public MainPageFB Auth_FillPasswordField(string auth_password)
        {
            FindElement(Auth_PasswordField).Click();
            //FindElement(Auth_PasswordField).SendKeys(auth_password);
            return this;
        }

        /// <summary>
        /// This method click on button Submit for Sign In.
        /// </summary>
        /// <returns></returns>
        public MainPageFB Auth_ClickSubmitButton()
        {
            FindElement(Auth_BtnSubmit).Click();
            return this;
        }

        /// <summary>
        /// This method fill text in First Name field for user registration.
        /// </summary>
        /// <param name="reg_firstname"></param>
        /// <returns></returns>
        public MainPageFB Reg_FillFirstNameField(string reg_firstname)
        {
            FindElement(Reg_FirstNameField).SendKeys(reg_firstname);
            return this;
        }

        /// <summary>
        /// This method fill text in Last Name field for user registration.
        /// </summary>
        /// <param name="reg_lastname"></param>
        /// <returns></returns>
        public MainPageFB Reg_FillLastNameField(string reg_lastname)
        {
            FindElement(Reg_LastNameField).SendKeys(reg_lastname);
            return this;
        }

        /// <summary>
        /// This method fill text in Phone number or Email field for user registration
        /// </summary>
        /// <param name="reg_phonenumberoremail"></param>
        /// <returns></returns>
        public MainPageFB Reg_FillPhoneNumberOrEmailField(string reg_phonenumberoremail)
        {
            FindElement(Reg_PhoneNumberOrEmailField).SendKeys(reg_phonenumberoremail);
            return this;
        }

        /// <summary>
        /// This method fill text in Password field for user registration
        /// </summary>
        /// <param name="reg_password"></param>
        /// <returns></returns>
        public MainPageFB Reg_FillPasswordField(string reg_password)
        {
            FindElement(Reg_PasswordField).SendKeys(reg_password);
            return this;
        }

        /// <summary>
        /// This method click on button Submit for create a new account.
        /// </summary>
        /// <returns></returns>
        public MainPageFB Reg_ClickSubmitButton()
        {
            FindElement(Reg_BtnSubmit).Click();
            return this;
        }

        /// <summary>
        /// Get error text for Email field when the user tried to log in.
        /// </summary>
        /// <returns></returns>
        public string Auth_GetErrorForEmailField()
        {
            return GetErrorForField(FindElement(Auth_EmailOrPhoneNumberField));
        }

        /// <summary>
        /// Get error text for Password field when the user tried to log in.
        /// </summary>
        /// <returns></returns>
        public string Auth_GetErrorForPasswordField()
        {
            return GetErrorForField(FindElement(Auth_PasswordField));
        }

        /// <summary>
        /// Get error text for First Name field when the user tried to create an account.
        /// </summary>
        /// <returns></returns>
        public string Reg_GetErrorForFirstNameField()
        {
            return GetErrorForField(FindElement(Reg_FirstNameField));
        }

        /// <summary>
        /// Get error text for Last Name field when the user tried to create an account.
        /// </summary>
        /// <returns></returns>
        public string Reg_GetErrorForLastNameField()
        {
            return GetErrorForField(FindElement(Reg_LastNameField));
        }

        /// <summary>
        /// Get error text for Email field when the user tried to create an account.
        /// </summary>
        /// <returns></returns>
        public string Reg_GetErrorForPhoneNumberOrEmailField()
        {
            return GetErrorForField(FindElement(Reg_PhoneNumberOrEmailField));
        }

        /// <summary>
        /// Get error text for Password field when the user tried to create an account.
        /// </summary>
        /// <returns></returns>
        public string Reg_GetErrorForPasswordField()
        {
            return GetErrorForField(FindElement(Reg_PasswordField));
        }
    }
}