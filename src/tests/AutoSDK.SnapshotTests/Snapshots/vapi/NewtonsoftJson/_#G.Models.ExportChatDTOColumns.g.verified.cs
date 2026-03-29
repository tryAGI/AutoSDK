//HintName: G.Models.ExportChatDTOColumns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Columns to include in the CSV export<br/>
    /// Default Value: [assistantId, cost, createdAt, id, messages, output, previousChatId, sessionId, squadId, updatedAt]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExportChatDTOColumns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistantId")]
        AssistantId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost")]
        Cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="createdAt")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="messages")]
        Messages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output")]
        Output,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="previousChatId")]
        PreviousChatId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sessionId")]
        SessionId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squadId")]
        SquadId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportChatDTOColumnsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportChatDTOColumns value)
        {
            return value switch
            {
                ExportChatDTOColumns.AssistantId => "assistantId",
                ExportChatDTOColumns.Cost => "cost",
                ExportChatDTOColumns.CreatedAt => "createdAt",
                ExportChatDTOColumns.Id => "id",
                ExportChatDTOColumns.Messages => "messages",
                ExportChatDTOColumns.Output => "output",
                ExportChatDTOColumns.PreviousChatId => "previousChatId",
                ExportChatDTOColumns.SessionId => "sessionId",
                ExportChatDTOColumns.SquadId => "squadId",
                ExportChatDTOColumns.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportChatDTOColumns? ToEnum(string value)
        {
            return value switch
            {
                "assistantId" => ExportChatDTOColumns.AssistantId,
                "cost" => ExportChatDTOColumns.Cost,
                "createdAt" => ExportChatDTOColumns.CreatedAt,
                "id" => ExportChatDTOColumns.Id,
                "messages" => ExportChatDTOColumns.Messages,
                "output" => ExportChatDTOColumns.Output,
                "previousChatId" => ExportChatDTOColumns.PreviousChatId,
                "sessionId" => ExportChatDTOColumns.SessionId,
                "squadId" => ExportChatDTOColumns.SquadId,
                "updatedAt" => ExportChatDTOColumns.UpdatedAt,
                _ => null,
            };
        }
    }
}