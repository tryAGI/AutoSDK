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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalCreateApprovalsVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalCreateApprovalsVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApprovalCreateApprovalsVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ApprovalReturn? approval = default;
            if (discriminator?.Type == global::G.ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Approval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalReturn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalReturn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApprovalReturn)}");
                approval = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LettaSchemasLettaMessageToolReturn? tool = default;
            if (discriminator?.Type == global::G.ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasLettaMessageToolReturn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasLettaMessageToolReturn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaSchemasLettaMessageToolReturn)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApproval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalReturn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalReturn?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApprovalReturn).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Approval, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasLettaMessageToolReturn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasLettaMessageToolReturn?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaSchemasLettaMessageToolReturn).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}