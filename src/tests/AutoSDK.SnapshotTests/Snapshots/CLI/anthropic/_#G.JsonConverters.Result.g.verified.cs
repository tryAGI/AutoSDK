//HintName: G.JsonConverters.Result.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Result>
    {
        /// <inheritdoc />
        public override global::G.Result Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaMessageBatchIndividualResponseResultDiscriminator>(ref readerCopy, options);

            global::G.BetaSucceededResult? succeeded = default;
            if (discriminator?.Type == global::G.BetaMessageBatchIndividualResponseResultDiscriminatorType.Succeeded)
            {
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaSucceededResult>(ref reader, options);
            }
            global::G.BetaErroredResult? errored = default;
            if (discriminator?.Type == global::G.BetaMessageBatchIndividualResponseResultDiscriminatorType.Errored)
            {
                errored = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaErroredResult>(ref reader, options);
            }
            global::G.BetaCanceledResult? canceled = default;
            if (discriminator?.Type == global::G.BetaMessageBatchIndividualResponseResultDiscriminatorType.Canceled)
            {
                canceled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaCanceledResult>(ref reader, options);
            }
            global::G.BetaExpiredResult? expired = default;
            if (discriminator?.Type == global::G.BetaMessageBatchIndividualResponseResultDiscriminatorType.Expired)
            {
                expired = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaExpiredResult>(ref reader, options);
            }

            var __value = new global::G.Result(
                discriminator?.Type,
                succeeded,

                errored,

                canceled,

                expired
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Result value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSucceeded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeof(global::G.BetaSucceededResult), options);
            }
            else if (value.IsErrored)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Errored, typeof(global::G.BetaErroredResult), options);
            }
            else if (value.IsCanceled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled, typeof(global::G.BetaCanceledResult), options);
            }
            else if (value.IsExpired)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expired, typeof(global::G.BetaExpiredResult), options);
            }
        }
    }
}