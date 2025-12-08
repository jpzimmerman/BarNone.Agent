from genaioutputparser import GenAIOutputParser
from google import genai

def main():
    client = genai.Client()
    response = client.models.generate_content(
    model="gemini-2.5-flash", contents="Provide recipes for a few popular cocktails that include the following ingredients: vodka, Midori"
)
    print(response.text)
    print('Hello World')


if __name__=="__main__":
    main()