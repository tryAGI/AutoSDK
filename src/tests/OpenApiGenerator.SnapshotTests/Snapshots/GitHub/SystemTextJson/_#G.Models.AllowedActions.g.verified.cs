//HintName: G.Models.AllowedActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
    /// </summary>
    public enum AllowedActions
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        LocalOnly,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AllowedActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedActions value)
        {
            return value switch
            {
                AllowedActions.All => "all",
                AllowedActions.LocalOnly => "local_only",
                AllowedActions.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedActions? ToEnum(string value)
        {
            return value switch
            {
                "all" => AllowedActions.All,
                "local_only" => AllowedActions.LocalOnly,
                "selected" => AllowedActions.Selected,
                _ => null,
            };
        }
    }
}