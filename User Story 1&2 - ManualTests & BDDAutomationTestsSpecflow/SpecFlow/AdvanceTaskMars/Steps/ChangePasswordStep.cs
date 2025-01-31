using AdvancedtaskSpecflow.Pages.Components.AccountMenu;
using AdvancedtaskSpecflow.Pages.Components.Login;
using AdvancedtaskSpecflow.Test_Model;
using AdvancedtaskSpecflow.Utilities;
using System;


namespace AdvancedtaskSpecflow.Steps
{
    public class ChangePasswordStep:LoginComponent
    {
        ChangePasswordComponent ChangePasswordComponentObj;
        public ChangePasswordStep()
        {
            ChangePasswordComponentObj = new ChangePasswordComponent();
        }
        public void PassswordChangeLoginSteps()
        {
            renderSignInComponent();
            signInButton.Click();
            renderAddComponents();
            List<ChangePassword> ChangePasswordList = JsonHelper.ReadTestDataFromJson<ChangePassword>("C:/Visual_studio_project/AdvancedTaskPART2/AdvancedtaskSpecflow/JsonData/ChangePassword.json");
            foreach (var data in ChangePasswordList)
            {
                Console.WriteLine(data);
                emailField.SendKeys("datatest@gmail.com");
                passwordField.SendKeys(data.CurrentPassword);
                loginButton.Click();
            }
        }
        public void AddNChangePassword(string AddJsonFilePath)
        {
            List<ChangePassword> ChangePasswordList = JsonHelper.ReadTestDataFromJson<ChangePassword>(AddJsonFilePath);
            foreach (var data in ChangePasswordList)
            {

                ChangePasswordComponentObj.changePassword(data);
                string actualmessage = ChangePasswordComponentObj.getMessage();
                Console.WriteLine(actualmessage);

            }
        }
    }
}
