using RestSharp;

var client = new RestClient("https://viacep.com.br/ws/01001000/json/");
var request = new RestRequest("cards", Method.Get);

var response = await client.GetAsync<CardsResponse>(request);

// foreach (var card in response.Cards)
//{
//    Console.WriteLine(card);
//}


