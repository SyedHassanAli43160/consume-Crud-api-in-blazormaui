namespace consumeapiinblazormaui.helper
{
    public class userapi
    {
        public HttpClient initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://crudapi20221230123721.azurewebsites.net/");
            return client;
        }
    }
}
                                                    