//HintName: G.Models.ArchiveFTModelOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ArchiveFTModelOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model")]
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArchiveFTModelOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArchiveFTModelOutObject value)
        {
            return value switch
            {
                ArchiveFTModelOutObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArchiveFTModelOutObject? ToEnum(string value)
        {
            return value switch
            {
                "model" => ArchiveFTModelOutObject.Model,
                _ => null,
            };
        }
    }
}