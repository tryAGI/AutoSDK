//HintName: G.Models.ProjectResponseModelState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="converting")]
        Converting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_queue")]
        InQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectResponseModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelState value)
        {
            return value switch
            {
                ProjectResponseModelState.Default => "default",
                ProjectResponseModelState.Converting => "converting",
                ProjectResponseModelState.InQueue => "in_queue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelState? ToEnum(string value)
        {
            return value switch
            {
                "default" => ProjectResponseModelState.Default,
                "converting" => ProjectResponseModelState.Converting,
                "in_queue" => ProjectResponseModelState.InQueue,
                _ => null,
            };
        }
    }
}