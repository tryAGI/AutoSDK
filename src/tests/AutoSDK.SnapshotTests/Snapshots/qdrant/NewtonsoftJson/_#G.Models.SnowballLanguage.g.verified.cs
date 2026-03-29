//HintName: G.Models.SnowballLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Languages supported by snowball stemmer.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SnowballLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="arabic")]
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="armenian")]
        Armenian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="danish")]
        Danish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dutch")]
        Dutch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="english")]
        English,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="finnish")]
        Finnish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="french")]
        French,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="german")]
        German,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="greek")]
        Greek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hungarian")]
        Hungarian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="italian")]
        Italian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="norwegian")]
        Norwegian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="portuguese")]
        Portuguese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="romanian")]
        Romanian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="russian")]
        Russian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spanish")]
        Spanish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swedish")]
        Swedish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tamil")]
        Tamil,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="turkish")]
        Turkish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnowballLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnowballLanguage value)
        {
            return value switch
            {
                SnowballLanguage.Arabic => "arabic",
                SnowballLanguage.Armenian => "armenian",
                SnowballLanguage.Danish => "danish",
                SnowballLanguage.Dutch => "dutch",
                SnowballLanguage.English => "english",
                SnowballLanguage.Finnish => "finnish",
                SnowballLanguage.French => "french",
                SnowballLanguage.German => "german",
                SnowballLanguage.Greek => "greek",
                SnowballLanguage.Hungarian => "hungarian",
                SnowballLanguage.Italian => "italian",
                SnowballLanguage.Norwegian => "norwegian",
                SnowballLanguage.Portuguese => "portuguese",
                SnowballLanguage.Romanian => "romanian",
                SnowballLanguage.Russian => "russian",
                SnowballLanguage.Spanish => "spanish",
                SnowballLanguage.Swedish => "swedish",
                SnowballLanguage.Tamil => "tamil",
                SnowballLanguage.Turkish => "turkish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnowballLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => SnowballLanguage.Arabic,
                "armenian" => SnowballLanguage.Armenian,
                "danish" => SnowballLanguage.Danish,
                "dutch" => SnowballLanguage.Dutch,
                "english" => SnowballLanguage.English,
                "finnish" => SnowballLanguage.Finnish,
                "french" => SnowballLanguage.French,
                "german" => SnowballLanguage.German,
                "greek" => SnowballLanguage.Greek,
                "hungarian" => SnowballLanguage.Hungarian,
                "italian" => SnowballLanguage.Italian,
                "norwegian" => SnowballLanguage.Norwegian,
                "portuguese" => SnowballLanguage.Portuguese,
                "romanian" => SnowballLanguage.Romanian,
                "russian" => SnowballLanguage.Russian,
                "spanish" => SnowballLanguage.Spanish,
                "swedish" => SnowballLanguage.Swedish,
                "tamil" => SnowballLanguage.Tamil,
                "turkish" => SnowballLanguage.Turkish,
                _ => null,
            };
        }
    }
}