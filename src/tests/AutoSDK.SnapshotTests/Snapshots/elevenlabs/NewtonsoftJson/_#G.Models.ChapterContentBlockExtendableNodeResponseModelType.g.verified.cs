//HintName: G.Models.ChapterContentBlockExtendableNodeResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChapterContentBlockExtendableNodeResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="_other")]
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChapterContentBlockExtendableNodeResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterContentBlockExtendableNodeResponseModelType value)
        {
            return value switch
            {
                ChapterContentBlockExtendableNodeResponseModelType.Other => "_other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterContentBlockExtendableNodeResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "_other" => ChapterContentBlockExtendableNodeResponseModelType.Other,
                _ => null,
            };
        }
    }
}