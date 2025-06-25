//HintName: G.Commands.PvcVoiceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PvcVoiceCommand : global::System.CommandLine.Command
    {
        public PvcVoiceCommand(
            CreateVoicesPvcCommand command0,
            CreateVoicesPvcByVoiceIdCommand command1,
            CreateVoicesPvcByVoiceIdSamplesCommand command2,
            CreateVoicesPvcByVoiceIdSamplesBySampleIdCommand command3,
            DeleteVoicesPvcByVoiceIdSamplesBySampleIdCommand command4,
            GetVoicesPvcByVoiceIdSamplesBySampleIdAudioCommand command5,
            GetVoicesPvcByVoiceIdSamplesBySampleIdWaveformCommand command6,
            GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersCommand command7,
            CreateVoicesPvcByVoiceIdSamplesBySampleIdSeparateSpeakersCommand command8,
            GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersBySpeakerIdAudioCommand command9,
            GetVoicesPvcByVoiceIdCaptchaCommand command10,
            CreateVoicesPvcByVoiceIdCaptchaCommand command11,
            CreateVoicesPvcByVoiceIdTrainCommand command12,
            CreateVoicesPvcByVoiceIdVerificationCommand command13)
            : base(
                name: "pvcvoice")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
        }
    }
}