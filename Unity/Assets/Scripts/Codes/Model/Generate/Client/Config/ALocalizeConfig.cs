//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace ET
{

public abstract partial class ALocalizeConfig: Bright.Config.BeanBase
{
    public ALocalizeConfig(ByteBuf _buf) 
    {
        Key = _buf.ReadString();
        PostInit();
    }

    public static ALocalizeConfig DeserializeALocalizeConfig(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case LocalizeConfig_CHS.__ID__: return new LocalizeConfig_CHS(_buf);
            case LocalizeConfig_CHT.__ID__: return new LocalizeConfig_CHT(_buf);
            case LocalizeConfig_EN.__ID__: return new LocalizeConfig_EN(_buf);
            default: throw new SerializationException();
        }
    }

    public string Key { get; private set; }


    public virtual void Resolve(Dictionary<string, IConfigSingleton> _tables)
    {
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Key:" + Key + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}