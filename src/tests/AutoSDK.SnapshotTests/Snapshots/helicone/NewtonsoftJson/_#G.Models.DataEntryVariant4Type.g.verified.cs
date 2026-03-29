//HintName: G.Models.DataEntryVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DataEntryVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output-body")]
        OutputBody,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataEntryVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataEntryVariant4Type value)
        {
            return value switch
            {
                DataEntryVariant4Type.OutputBody => "output-body",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataEntryVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "output-body" => DataEntryVariant4Type.OutputBody,
                _ => null,
            };
        }
    }
}