//HintName: G.Models.ExportSessionDTOColumns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Columns to include in the CSV export<br/>
    /// Default Value: [assistantId, cost, createdAt, customerName, customerNumber, id, messages, name, phoneNumberId, squadId, status, updatedAt]
    /// </summary>
    public enum ExportSessionDTOColumns
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantId,
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        CustomerName,
        /// <summary>
        /// 
        /// </summary>
        CustomerNumber,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Messages,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumberId,
        /// <summary>
        /// 
        /// </summary>
        SquadId,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportSessionDTOColumnsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportSessionDTOColumns value)
        {
            return value switch
            {
                ExportSessionDTOColumns.AssistantId => "assistantId",
                ExportSessionDTOColumns.Cost => "cost",
                ExportSessionDTOColumns.CreatedAt => "createdAt",
                ExportSessionDTOColumns.CustomerName => "customerName",
                ExportSessionDTOColumns.CustomerNumber => "customerNumber",
                ExportSessionDTOColumns.Id => "id",
                ExportSessionDTOColumns.Messages => "messages",
                ExportSessionDTOColumns.Name => "name",
                ExportSessionDTOColumns.PhoneNumberId => "phoneNumberId",
                ExportSessionDTOColumns.SquadId => "squadId",
                ExportSessionDTOColumns.Status => "status",
                ExportSessionDTOColumns.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportSessionDTOColumns? ToEnum(string value)
        {
            return value switch
            {
                "assistantId" => ExportSessionDTOColumns.AssistantId,
                "cost" => ExportSessionDTOColumns.Cost,
                "createdAt" => ExportSessionDTOColumns.CreatedAt,
                "customerName" => ExportSessionDTOColumns.CustomerName,
                "customerNumber" => ExportSessionDTOColumns.CustomerNumber,
                "id" => ExportSessionDTOColumns.Id,
                "messages" => ExportSessionDTOColumns.Messages,
                "name" => ExportSessionDTOColumns.Name,
                "phoneNumberId" => ExportSessionDTOColumns.PhoneNumberId,
                "squadId" => ExportSessionDTOColumns.SquadId,
                "status" => ExportSessionDTOColumns.Status,
                "updatedAt" => ExportSessionDTOColumns.UpdatedAt,
                _ => null,
            };
        }
    }
}