//HintName: G.JsonConverters.Result2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Result2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Result2>
    {
        /// <inheritdoc />
        public override global::G.Result2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageBatchIndividualResponseResultDiscriminator>(ref readerCopy, options);

            global::G.SucceededResult? succeeded = default;
            if (discriminator?.Type == global::G.MessageBatchIndividualResponseResultDiscriminatorType.Succeeded)
            {
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SucceededResult>(ref reader, options);
            }
            global::G.ErroredResult? errored = default;
            if (discriminator?.Type == global::G.MessageBatchIndividualResponseResultDiscriminatorType.Errored)
            {
                errored = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ErroredResult>(ref reader, options);
            }
            global::G.CanceledResult? canceled = default;
            if (discriminator?.Type == global::G.MessageBatchIndividualResponseResultDiscriminatorType.Canceled)
            {
                canceled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CanceledResult>(ref reader, options);
            }
            global::G.ExpiredResult? expired = default;
            if (discriminator?.Type == global::G.MessageBatchIndividualResponseResultDiscriminatorType.Expired)
            {
                expired = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpiredResult>(ref reader, options);
            }

            var __value = new global::G.Result2(
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
            global::G.Result2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSucceeded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeof(global::G.SucceededResult), options);
            }
            else if (value.IsErrored)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Errored, typeof(global::G.ErroredResult), options);
            }
            else if (value.IsCanceled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled, typeof(global::G.CanceledResult), options);
            }
            else if (value.IsExpired)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expired, typeof(global::G.ExpiredResult), options);
            }
        }
    }
}