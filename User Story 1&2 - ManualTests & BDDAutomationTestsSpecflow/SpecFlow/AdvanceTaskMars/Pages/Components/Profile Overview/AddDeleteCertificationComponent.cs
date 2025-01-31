using AdvancedtaskSpecflow.Test_Model;
using AdvancedtaskSpecflow.Utilities;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AdvancedtaskSpecflow.Pages.Components.Certifications
{
    public class AddDeleteCertificationComponent:CommonDriver
    {
        
        private IWebElement CertificateorAward;
        private IWebElement CertifiedFrom;
        private IWebElement Title;
        private IWebElement messageBox;
        private IWebElement deleteMessageBox;
        private IWebElement AddButton;
        private IWebElement certifiedYear;
        private IWebElement ElementToDelete;
        private IWebElement deletebutton;
        private IWebElement AddNew;
        private IWebElement closeMessageIcon;
        public void renderAddComponents()
        {
            try
            {
                CertificateorAward = driver.FindElement(By.XPath("//div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
                CertifiedFrom = driver.FindElement(By.Name("certificationFrom"));
                certifiedYear = driver.FindElement(By.Name("certificationYear"));
                AddButton = driver.FindElement(By.XPath("//div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddMessage()
        {
            try
            {
                messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex);
            }
        }
        public void renderDeleteMessage()
        {
            try
            {
                //messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                deleteMessageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Item not found--");
                Console.WriteLine(ex);
            }
        }
        public void renderDeleteCertification()
        {
            try
            {
                ElementToDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
                deletebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
     
        public void addNewCertification(CertificationModel data)
        {

            //AddNew and add award name;
            renderAddComponents();
            Thread.Sleep(2000);
            CertificateorAward.Click();
            CertificateorAward.SendKeys(data.certificateorAward);

            //Select the name of the Country
            Wait.WaitToBeVisible(driver, "Name", "certificationFrom", 3);
            CertifiedFrom.Click();
            CertifiedFrom.SendKeys(data.certifiedFrom);
            
            //Select the Title
            Wait.WaitToBeVisible(driver, "Name", "certificationYear", 3);
            SelectElement chooseCertifiedYear = new SelectElement(certifiedYear);
            chooseCertifiedYear.SelectByText(data.certifiedYear);

            //Click on Add button
            Wait.WaitToBeClickable(driver, "XPath", "//input [contains (@class, 'ui teal button')]", 3);
            AddButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 15);
        }
        public void DeleteCertification()
        {
            renderDeleteCertification();
            Thread.Sleep(2000);
            deletebutton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 15);
        }
        public string GetMessageWindow()
        {
            renderAddMessage();
            string Message = messageBox.Text;
           Thread.Sleep(4000);
            return Message;
        }
        public string GetDeleteMessageWindow()
        {
            renderDeleteMessage();
            string deleteMessage = messageBox.Text;
            Console.WriteLine($"deleteMessage--{deleteMessage}");
            Thread.Sleep(4000);
            return deleteMessage;
        }
    }
}


