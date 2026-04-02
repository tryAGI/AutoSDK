//HintName: G.JsonConverters.ApprovalsVariant1Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ApprovalsVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ApprovalsVariant1Item>
    {
        /// <inheritdoc />
        public override global::G.ApprovalsVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApprovalCreateApprovalsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::G.ApprovalReturn? approval = default;
            if (discriminator?.Type == global::G.ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Approval)
            {
                approval = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApprovalReturn>(ref reader, options);
            }
            global::G.LettaSchemasLettaMessageToolReturn? tool = default;
            if (discriminator?.Type == global::G.ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaSchemasLettaMessageToolReturn>(ref reader, options);
            }

            var __value = new global::G.ApprovalsVariant1Item(
                discriminator?.Type,
                approval,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ApprovalsVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApproval)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Approval, typeof(global::G.ApprovalReturn), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.LettaSchemasLettaMessageToolReturn), options);
            }
        }
    }
}