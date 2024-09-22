//HintName: G.Models.Mode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Mode describes the execution mode of the pipeline (sync or async).<br/>
    ///  - MODE_SYNC: Synchronous (result is returned in the response).<br/>
    ///  - MODE_ASYNC: Asynchronous (response only contains acknowledgement).
    /// </summary>
    public enum Mode
    {
        /// <summary>
        /// Synchronous (result is returned in the response).
        /// </summary>
        MODESYNC,
        /// <summary>
        /// Asynchronous (response only contains acknowledgement).
        /// </summary>
        MODEASYNC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Mode value)
        {
            return value switch
            {
                Mode.MODESYNC => "MODE_SYNC",
                Mode.MODEASYNC => "MODE_ASYNC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Mode? ToEnum(string value)
        {
            return value switch
            {
                "MODE_SYNC" => Mode.MODESYNC,
                "MODE_ASYNC" => Mode.MODEASYNC,
                _ => null,
            };
        }
    }
}