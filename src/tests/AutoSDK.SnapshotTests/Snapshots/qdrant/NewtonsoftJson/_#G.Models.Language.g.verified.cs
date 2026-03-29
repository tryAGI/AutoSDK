//HintName: G.Models.Language.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Language
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="arabic")]
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azerbaijani")]
        Azerbaijani,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basque")]
        Basque,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bengali")]
        Bengali,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="catalan")]
        Catalan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chinese")]
        Chinese,
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
        [global::System.Runtime.Serialization.EnumMember(Value="hebrew")]
        Hebrew,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hinglish")]
        Hinglish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hungarian")]
        Hungarian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="indonesian")]
        Indonesian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="italian")]
        Italian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="japanese")]
        Japanese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kazakh")]
        Kazakh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nepali")]
        Nepali,
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
        [global::System.Runtime.Serialization.EnumMember(Value="slovene")]
        Slovene,
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
        [global::System.Runtime.Serialization.EnumMember(Value="tajik")]
        Tajik,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="turkish")]
        Turkish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Language value)
        {
            return value switch
            {
                Language.Arabic => "arabic",
                Language.Azerbaijani => "azerbaijani",
                Language.Basque => "basque",
                Language.Bengali => "bengali",
                Language.Catalan => "catalan",
                Language.Chinese => "chinese",
                Language.Danish => "danish",
                Language.Dutch => "dutch",
                Language.English => "english",
                Language.Finnish => "finnish",
                Language.French => "french",
                Language.German => "german",
                Language.Greek => "greek",
                Language.Hebrew => "hebrew",
                Language.Hinglish => "hinglish",
                Language.Hungarian => "hungarian",
                Language.Indonesian => "indonesian",
                Language.Italian => "italian",
                Language.Japanese => "japanese",
                Language.Kazakh => "kazakh",
                Language.Nepali => "nepali",
                Language.Norwegian => "norwegian",
                Language.Portuguese => "portuguese",
                Language.Romanian => "romanian",
                Language.Russian => "russian",
                Language.Slovene => "slovene",
                Language.Spanish => "spanish",
                Language.Swedish => "swedish",
                Language.Tajik => "tajik",
                Language.Turkish => "turkish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Language? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => Language.Arabic,
                "azerbaijani" => Language.Azerbaijani,
                "basque" => Language.Basque,
                "bengali" => Language.Bengali,
                "catalan" => Language.Catalan,
                "chinese" => Language.Chinese,
                "danish" => Language.Danish,
                "dutch" => Language.Dutch,
                "english" => Language.English,
                "finnish" => Language.Finnish,
                "french" => Language.French,
                "german" => Language.German,
                "greek" => Language.Greek,
                "hebrew" => Language.Hebrew,
                "hinglish" => Language.Hinglish,
                "hungarian" => Language.Hungarian,
                "indonesian" => Language.Indonesian,
                "italian" => Language.Italian,
                "japanese" => Language.Japanese,
                "kazakh" => Language.Kazakh,
                "nepali" => Language.Nepali,
                "norwegian" => Language.Norwegian,
                "portuguese" => Language.Portuguese,
                "romanian" => Language.Romanian,
                "russian" => Language.Russian,
                "slovene" => Language.Slovene,
                "spanish" => Language.Spanish,
                "swedish" => Language.Swedish,
                "tajik" => Language.Tajik,
                "turkish" => Language.Turkish,
                _ => null,
            };
        }
    }
}