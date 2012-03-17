using System;

namespace FluentFileSystem.Tokenization
{
    ///<summary>
    /// Sets the replacement text
    ///</summary>
    public class TokenWith
    {
        private readonly TokenReplacer _replacer;

        internal TokenWith(TokenReplacer replacer)
        {
            this._replacer = replacer;
        }

        ///<summary>
        /// Replaces the input with a value
        ///</summary>
        ///<param name="value">The value to use in the replacement</param>
        public TokenReplacer With(string value)
        {
            _replacer.Input = _replacer.Input.Replace(String.Format("@{0}@", _replacer.Token), value);
            return _replacer;
        }
    }
}