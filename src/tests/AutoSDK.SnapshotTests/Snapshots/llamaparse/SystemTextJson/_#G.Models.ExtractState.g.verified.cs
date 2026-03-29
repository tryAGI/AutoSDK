//HintName: G.Models.ExtractState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtractState
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractState value)
        {
            return value switch
            {
                ExtractState.Created => "CREATED",
                ExtractState.Error => "ERROR",
                ExtractState.Pending => "PENDING",
                ExtractState.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractState? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => ExtractState.Created,
                "ERROR" => ExtractState.Error,
                "PENDING" => ExtractState.Pending,
                "SUCCESS" => ExtractState.Success,
                _ => null,
            };
        }
    }
}