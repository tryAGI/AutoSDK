//HintName: G.Models.CreateClipResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this clip
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip")]
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipResponseObject value)
        {
            return value switch
            {
                CreateClipResponseObject.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "clip" => CreateClipResponseObject.Clip,
                _ => null,
            };
        }
    }
}