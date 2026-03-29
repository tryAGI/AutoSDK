//HintName: G.Models.NewDatasetParamsDatasetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NewDatasetParamsDatasetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="helicone")]
        Helicone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewDatasetParamsDatasetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewDatasetParamsDatasetType value)
        {
            return value switch
            {
                NewDatasetParamsDatasetType.Experiment => "experiment",
                NewDatasetParamsDatasetType.Helicone => "helicone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewDatasetParamsDatasetType? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => NewDatasetParamsDatasetType.Experiment,
                "helicone" => NewDatasetParamsDatasetType.Helicone,
                _ => null,
            };
        }
    }
}