using System;
using System.Collections.Generic;
public class UIID {
    private static List<UIID> uiids = new List<UIID>();
	readonly UIID instance;
    public readonly static char[] charset = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
    public readonly static char[] specialChars = {'M', 'L', 'k', '=', '.', ' '};
    private string val { get; set; } = string.Empty;
    public UIID() {
        instance = this;
        uiids.Add(instance);
        generate();
    }
    public void regenerate(){
        generate();
    }
    public UIID getInstance(){
        return instance;
    }
    private void generate(){
        for(int i = 0; i < 32; i++){
            if(((i + 1) % 6) == 0){
                Random randomCreatorfd = new System.Random();
                var randomValfd = randomCreatorfd.Next(0, 1);
                val += specialChars[specialChars.Length * randomValfd].ToString();
            }
            if(((i + 1) % 8) == 0) {
                val += "-";
                continue;
            }
            Random randomCreator = new System.Random();
            var randomVal = randomCreator.Next(0, 1);
            val += charset[charset.Length * randomVal].ToString();
        }
        foreach (UIID uiid in uiids)
        {
            if(uiid.getVal() == val && uiid.getInstance() != instance){
                regenerate();
            }
        }
    }
    public string getVal(){
        return val;
    }
}