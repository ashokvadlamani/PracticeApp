namespace PracticeApp 
{
    internal class MethodOverriding : MethodOverloading
    {
        public override string GetAddress(string id)
        {
            //get address from an external service
            string baseResponse = base.GetAddress(id);
            return baseResponse;
        }
    }
}