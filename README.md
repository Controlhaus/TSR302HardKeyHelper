# TSR302HardKeyHelper
Simpl# Pro Class to translate TSR-302 hard key numbers into names

Sample Usage
private void ui_SigChange(BasicTriList currentDevice, SigEventArgs args)
{
    if (args.Sig.Type == eSigType.Bool)
    {                    
        string hardKeyName;
        if (hardKeyHelper.hardKeys.TryGetValue(args.Sig.Number, out hardKeyName))
        {
            switch (hardKeyName)
            {
                case "volumeUp":
                    if (args.Sig.BoolValue)
                    {
                        //Start volume up ramp
                    }
                    else
                    {
                      //Stop volume ramp
                    }
                    break;
            }
        }
    }
}
