//HintName: G.Models.RetentionObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type that the retention policy applies to
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetentionObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_logs")]
        ProjectLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionObjectType value)
        {
            return value switch
            {
                RetentionObjectType.Dataset => "dataset",
                RetentionObjectType.Experiment => "experiment",
                RetentionObjectType.ProjectLogs => "project_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RetentionObjectType.Dataset,
                "experiment" => RetentionObjectType.Experiment,
                "project_logs" => RetentionObjectType.ProjectLogs,
                _ => null,
            };
        }
    }
}