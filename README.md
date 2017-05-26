# TSR302HardKeyHelper
Simpl# Pro Class to translate TSR-302 hard key numbers into names

Sample Usage:
```
private void ui_SigChange(BasicTriList currentDevice, SigEventArgs args)
{
    if (args.Sig.Type == eSigType.Bool)
    {                    
        if (TSR302HardKeyHelper.IsDefined((TSR302HardKeyHelper.HardKeys)args.Sig.Number))
        {
            switch (args.Sig.Number)
            {
                case (uint)TSR302HardKeyHelper.HardKeys.volumeUp:
                    if (args.Sig.BoolValue)
                    {
                        //Start volume up ramp
                    }
                    else
                    {
                      //Stop volume ramp
                    }
                    break;
                case (uint)TSR302HardKeyHelper.HardKeys.volumeDown:
                    break;
            }
        }
    }
}
```
