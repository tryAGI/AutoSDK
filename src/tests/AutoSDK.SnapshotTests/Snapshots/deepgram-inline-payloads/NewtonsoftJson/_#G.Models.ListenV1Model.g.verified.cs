//HintName: G.Models.ListenV1Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AI model used for transcription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListenV1Model
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-3")]
        Nova3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2")]
        Nova2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base")]
        Base,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced")]
        Enhanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Model value)
        {
            return value switch
            {
                ListenV1Model.Nova3 => "nova-3",
                ListenV1Model.Nova2 => "nova-2",
                ListenV1Model.Base => "base",
                ListenV1Model.Enhanced => "enhanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Model? ToEnum(string value)
        {
            return value switch
            {
                "nova-3" => ListenV1Model.Nova3,
                "nova-2" => ListenV1Model.Nova2,
                "base" => ListenV1Model.Base,
                "enhanced" => ListenV1Model.Enhanced,
                _ => null,
            };
        }
    }
}