//HintName: G.Models.HandoffToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the tool.<br/>
    /// When you're using handoff tool, we recommend adding this to your system prompt<br/>
    /// ---<br/>
    /// # System context<br/>
    /// You are part of a multi-agent system designed to make agent coordination and execution easy. Agents uses two primary abstraction: **Agents** and **Handoffs**. An agent encompasses instructions and tools and can hand off a conversation to another agent when appropriate. Handoffs are achieved by calling a handoff function, generally named `handoff_to_&lt;agent_name&gt;`. Handoffs between agents are handled seamlessly in the background; do not mention or draw attention to these handoffs in your conversation with the user.<br/>
    /// # Agent context<br/>
    /// {put your agent system prompt here}<br/>
    /// ---
    /// </summary>
    public enum HandoffToolType
    {
        /// <summary>
        /// **Agents** and **Handoffs**. An agent encompasses instructions and tools and can hand off a conversation to another agent when appropriate. Handoffs are achieved by calling a handoff function, generally named `handoff_to_&lt;agent_name&gt;`. Handoffs between agents are handled seamlessly in the background; do not mention or draw attention to these handoffs in your conversation with the user.
        /// </summary>
        Handoff,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HandoffToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HandoffToolType value)
        {
            return value switch
            {
                HandoffToolType.Handoff => "handoff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HandoffToolType? ToEnum(string value)
        {
            return value switch
            {
                "handoff" => HandoffToolType.Handoff,
                _ => null,
            };
        }
    }
}