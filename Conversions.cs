
namespace PracticeApp
{
    public class Conversions
    {

        public void ConvertStringInt()
        {
            try
            {
                string name = "15";
                bool result = int.TryParse(name,out int convertedValue);
                if(result)
                {
                    Console.WriteLine("conversion is successfule");
                }
                else
                {
                    Console.WriteLine("conversion is failed");
                }
            }
            catch(Exception exception)
            {

            }


        }

    }

}