// See https://aka.ms/new-console-template for more information
using Google.GenAI;

var aiClient = new Client();

var response = await aiClient.Models.GenerateContentAsync(
	model: "gemini-2.5-flash",
	contents: "Provide recipes for a few popular cocktails that include the following ingredients: vodka, Midori"
	);

Console.WriteLine(response.Candidates?[0].Content.Parts?[0].Text);