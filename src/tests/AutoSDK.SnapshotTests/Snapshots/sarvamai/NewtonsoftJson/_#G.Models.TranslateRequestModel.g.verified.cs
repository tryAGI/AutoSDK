//HintName: G.Models.TranslateRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Translation model to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslateRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mayura:v1")]
        Mayura_v1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sarvam-translate:v1")]
        SarvamTranslate_v1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestModel value)
        {
            return value switch
            {
                TranslateRequestModel.Mayura_v1 => "mayura:v1",
                TranslateRequestModel.SarvamTranslate_v1 => "sarvam-translate:v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "mayura:v1" => TranslateRequestModel.Mayura_v1,
                "sarvam-translate:v1" => TranslateRequestModel.SarvamTranslate_v1,
                _ => null,
            };
        }
    }
}