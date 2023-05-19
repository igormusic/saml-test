using Saml;
using System;

namespace saml_test
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                // 1. TODO: specify the certificate that your SAML provider gave you
                string samlCertificate = System.Configuration.ConfigurationManager.AppSettings["SSOCert"];

                try
                {
                    // 2. Let's read the data - SAML providers usually POST it into the "SAMLResponse" var
                    var samlResponse = new Response(samlCertificate, Request.Form["SAMLResponse"]);

                    if (!samlResponse.IsValid()) //all good?
                    {
                        Response.Write("Invalid SAML");
                    }
             
                    //WOOHOO!!! the user is logged in
                    var username = samlResponse.GetNameID(); //let's get the username
                    var email = samlResponse.GetEmail();
                    Response.Write("username:"+ username);
                    Response.Write("<br/>");
                    Response.Write("email:" + email);

                }
                catch (Exception ex) {
                    Response.Write("Invalid SAML");
                    Response.Write("exception:" + ex.Message);
                }

                // 3. DONE!
               

            }

        }
    }
}