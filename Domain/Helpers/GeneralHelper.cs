namespace Domain.Helpers
{
    public static class GeneralHelper
    {
        /// <summary>
        /// Generate Random Code
        /// </summary>
        /// <param name="length">Length of code will be return</param>
        /// <returns>Random Character</returns>
        public static string GenerateRandomCode(int length)
        {
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string characters = numbers;
            characters += alphabets + numbers;

            string code = string.Empty;

            for (int i = 0; i < length; i++)
            {
                string character;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (code.IndexOf(character) != -1);

                code += character;
            }

            return code;
        }

        /// <summary>
        /// Generate New Serial No.
        /// </summary>
        /// <param name="lengthSerial">Length Serial No</param>
        /// <param name="lastSerial">Last of the serial no</param>
        /// <param name="lastYY">Last of the Year (2 digit)</param>
        /// <param name="lastMM">Last of the Month (2 digit)</param>
        /// <returns>New Serial No.</returns>
        public static string GenerateSerialNo(int lengthSerial, string lastSerial = "", string lastYY = "", string lastMM = "")
        {
            DateTime today = DateTime.Now;
            string YY = today.Date.ToString("yy");
            string MM = today.Date.ToString("MM");

            if (!string.IsNullOrEmpty(lastSerial))
                lengthSerial = lastSerial.Length;

            string sNo = DefaultStartSerialNo(lengthSerial);

            if (!string.IsNullOrEmpty(lastSerial))
            {
                if (YY == lastYY && MM == lastMM)
                {

                    int nNo = int.Parse(lastSerial) + 1;
                    sNo = nNo.ToString();
                    int nLen = sNo.Length;
                    for (int i = 1; i <= (lengthSerial - nLen); i++)
                    {
                        sNo = "0" + sNo;
                    }
                }
            }

            return sNo;

        }


        /// <summary>
        /// Get Start Serial No
        /// </summary>
        /// <param name="sLength">Length Serial No</param>
        /// <returns>Start Serial No</returns>
        public static string DefaultStartSerialNo(int sLength)
        {
            string startSerial = "1";
            for (int i = 1; i < sLength; i++)
            {
                startSerial = "0" + startSerial;
            }

            return startSerial;
        }
    }
}
