List<string> data = new List<string>();
List<string> encryptedData = new List<string>();
int match = 0;

data.Add("dfl");
data.Add("zio");
data.Add("vyw");
data.Add("rpc");
data.Add("qlb");
data.Add("sqd");
data.Add("egm");
data.Add("ajp");

Encryption demo = new Encryption();
encryptedData = demo.encrypt(data);

foreach(string key in encryptedData)
{
    Console.WriteLine(key);
}

match = demo.getMatch(data, encryptedData);
Console.WriteLine(match);

class Encryption
{
    public List<string> encrypt(List<string> inputs)
    {
        List<string> output = new List<string>();
        char[] encryptedKey;
        char[] captureItem;
        string keyBuilder;
        for(int i = 0; i < inputs.Count(); i++)
        {
            captureItem = inputs[i].ToCharArray();
            encryptedKey = new char[captureItem.Length];
            for (int j = 0; j < captureItem.Length; j++)
            {
                char key = captureItem[j];
                if (key != 'z')
                    key++;
                else
                    key = 'a';
                encryptedKey[j]=key;
            }
            keyBuilder = new string(encryptedKey);
            output.Add(keyBuilder);

        }
        return output;

    }

    public int getMatch(List<string> data, List<string> encyptedData)
    {
        int matches = 0;
        
        for (int i = 0; i < data.Count; i++)
        {
            for (int j = 0; j < encyptedData.Count; j++)
            {
                if( data[i] == encyptedData[j]) 
                    matches++;
            }
        }

        return matches;
    }
}