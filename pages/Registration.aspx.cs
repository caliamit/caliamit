using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
public partial class pages_registration : System.Web.UI.Page
{

    public string data;
    public string firstName;
    public string lastName;
    public string userName;
    public string idNum;
    public string phone;
    public string mail;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            if (Request.Form["userName"] != null)
            {
                if (FormValidation())
                {
                    string dbPath = this.MapPath("../App_Data/Database.mdf");
                    DAL dal = new DAL(dbPath);

                    string sqlQuery = "SELECT * FROM users WHERE usr_userName = '" +
                                Request.Form["userName"].ToString() + "'";
                    DataSet ds = dal.GetDataSet(sqlQuery);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        data = "שם משתמש קיים במערכת. אנא בחר.י שם אחר.";
                        ReturnFieldsValue();
                    }
                    else
                    {
                        data += "ההרשמה בוצעה בהצלחה";
                        sqlQuery = "INSERT INTO Users VALUES (" +
                        "'" + Request.Form["firstName"].ToString() + "', " +
                        "'" + Request.Form["lastName"].ToString() + "', " +
                        "'" + Request.Form["userName"].ToString() + "', " +
                        "'" + Request.Form["pswd"].ToString() + "', " +
                        "'" + Request.Form["idNum"].ToString() + "'," +
                        "'" + Request.Form["phone"].ToString() + "'," +
                        "'" + Request.Form["mail"].ToString() + "'," +
                        "'" + "male"/*Request.Form["gender"].ToString()*/ + "'," +
                        "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                        "0);";
                        dal.UpdateDB(sqlQuery);
                    }


                }
                else
                {
                    ReturnFieldsValue();
                }
            }
        }
    }

    public void ReturnFieldsValue()
    {
        firstName = Request.Form["firstName"].ToString();
        lastName = Request.Form["lastName"].ToString();
        userName = Request.Form["userName"].ToString();
        idNum = Request.Form["idNum"].ToString();
        phone = Request.Form["phone"].ToString();
        mail = Request.Form["mail"].ToString();
    }
    public bool FormValidation()
    {
        return
                FirstNameValidation() &&
                LastNameValidation() &&
                UserNameValidation() &&
                PasswordValidation() &&
                IDValidation() &&
                PhoneValidation() &&
                EmailValidation() &&
                ApprovalValidation();
    }

    private bool FirstNameValidation()
    {
        string fname = Request.Form["firstName"].ToString();

        if (fname.Length < 2)
        {
            data += "שם פרטי חייב להכיל לפחות שני תווים.";
            return false;
        }

        return true;
    }

    private bool LastNameValidation()
    {
        string lname = Request.Form["lastName"].ToString();

        if (lname.Length < 2)
        {
            data += "שם משפחה חייב להכיל לפחות שני תווים.";
            return false;
        }

        return true;
    }

    private bool UserNameValidation()
    {
        string uname = Request.Form["userName"].ToString();

        //קוד שמוודא ששם המשתמש בן 3 ל-8 תווים בלבד
        if (uname.Length < 3 || uname.Length > 8)
        {
            data += "שם משתמש חייב להכיל בין 3 ל-8 תווים.";
            return false;
        }

        return true;
    }

    private bool PasswordValidation()
    {
        string pswd = Request.Form["pswd"].ToString();

        //קוד שמוודא שהסיסמה בן 8 ל-10 תווים בלבד
        if (pswd.Length < 8 || pswd.Length > 20)
        {
            data += "הסיסמה חייבת להכיל בין 8 ל-20 תווים";
            return false;
        }

        //קוד שמוודא שהסיסמה מכילה אותיות ומספרים
        bool letterExist = false;
        bool numberExist = false;
        for (int i = 0; i < pswd.Length; i++)
        {
            //בדיקת קיום אותיות
            if (pswd[i] >= 'a' && pswd[i] <= 'z' || pswd[i] >= 'A' && pswd[i] <= 'Z')
                letterExist = true;
            //בדיקת קיום מספרים
            else if (pswd[i] >= '0' && pswd[i] <= '9')
                numberExist = true;
        }
        if (!letterExist || !numberExist)
        {
            data += "הסיסמה חייבת להכיל אותיות ומספרים";
            return false;
        }

        string pswdValidate = Request.Form["pswdValidate"].ToString();

        //קוד לוידוא סיסמה ווידוא סיסמה זהים
        if (pswdValidate != pswd)
        {
            data += "הסיסמה ווידוא הסיסמה אינם זהים";
            return false;
        }

        return true;
    }

    private bool IDValidation()
    {
        string idNumber = Request.Form["idNum"].ToString();

        //קוד שמוודא רצף של 9 ספרות בדיוק - יש לוודא גודל והכלה של ספרות בלבד
        if (idNumber.Length != 9)
        {
            data += "מספר תעודת זהות חייב להכיל 9 ספרות בלבד.";
            return false;
        }

        //קוד שמוודא שתעודת הזהות מכילה מספרים בלבד
        for (int i = 0; i < idNumber.Length; i++)
        {
            if (!(idNumber[i] >= '0' && idNumber[i] <= '9'))
            {
                data += "מספר תעודת זהות חייב להכיל ספרות בלבד.";
                return false;
            }
        }

        return true;
    }

    private bool PhoneValidation()
    {
        //קוד שמוודא רצף של 10 ספרות בדיוק - יש לוודא גודל והכלה של ספרות בלבד
        //בנוסף הקוד יוודא שהספרה הראשונה היא 0

        string phoneNum = Request.Form["phone"].ToString();

        if (phoneNum.Length != 10)
        {
            data += "מספר הטלפון חייב להכיל 10 ספרות בלבד.";
            return false;
        }

        if (phoneNum[0] != '0')
        {
            data += "מספר טלפון לא תקין. ספרה ראשונה חייבת להיות 0.";
            return false;
        }

        for (int i = 0; i < phoneNum.Length; i++)
        {
            if (!(phoneNum[i] >= '0' && phoneNum[i] <= '9'))
            {
                data += "מספר הטלפון חייב להכיל ספרות בלבד.";
                return false;
            }
        }
        return true;
    }

    private bool EmailValidation()
    {
        //הקוד יוודא את הדברים הבאים:
        //קיים תו @ אחד בלבד שאינו התו הראשון
        //קיים תו . אחד בלבד שאינו התו האחרון והוא נמצא אחרי התו שטרודל
        string mailAddress = Request.Form["mail"].ToString();

        int atPos = -1;
        int dotPos = -1;

        for (int i = 0; i < mailAddress.Length; i++)
        {
            if (mailAddress[i] == '@')
            {
                if (atPos != -1 || i == 0)
                {
                    data += "אימייל לא תקין.";
                    return false;
                }
                atPos = i;
            }
            else if (mailAddress[i] == '.')
            {
                if (dotPos != -1 || atPos == -1 || i == atPos + 1 || i == mailAddress.Length - 1)
                {
                    data += "אימייל לא תקין.";
                    return false;
                }
                dotPos = i;
            }
        }

        if (atPos == -1 || dotPos == -1)
        {
            data += "אימייל לא תקין.";
            return false;
        }

        return true;
    }

    private bool ApprovalValidation()
    {
        if (Request.Form["approval"] == null)
        {
            data += "יש לאשר את תקנון האתר.";
            return false;
        }

        return true;
    }
}

