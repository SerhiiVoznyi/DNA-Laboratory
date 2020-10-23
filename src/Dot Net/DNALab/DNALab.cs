namespace DNALab
{
    using System;
    using Text.Encoding;

    public class DNALab
    {
        private readonly Lazy<ITextEncoderDecoder> _text;

        public DNALab()
        {
            _text = new Lazy<ITextEncoderDecoder>(() => new TextEncoderDecoder());
        }

        public DNALab(ITextEncoderDecoder text)
        {
            _text = new Lazy<ITextEncoderDecoder>(() => text);
        }

        public ITextEncoderDecoder Text => _text.Value;
    }
}