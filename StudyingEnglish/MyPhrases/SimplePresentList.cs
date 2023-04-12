using StudyingEnglish.Models;

namespace StudyingEnglish.MyPhrases
{
    public class SimplePresentList
    {
        public List<SimplePresent> List()
        {
            var simplePresents = new List<SimplePresent>()
            {
                new SimplePresent
                {
                    Value = "What's your name?",
                    Description = "Qual é o seu nome?"
                },
                new SimplePresent
                {
                    Value = "Eu não estou dormindo agora.",
                    Description = "I'm not sleeping now."
                },
                new SimplePresent
                {
                    Value = "I don't speak French.",
                    Description = "Eu não falo Francês."
                },
                new SimplePresent
                {
                    Value = "He plays soccer very well.",
                    Description = "Ele joga futebol muito bem."
                },
                new SimplePresent
                {
                    Value = "I don't like soccer.",
                    Description = "Eu não gosto de futebol."
                },
                new SimplePresent
                {
                    Value = "Eu estou errado?",
                    Description = "Am my wrong?"
                },
                new SimplePresent
                {
                    Value = "How often do you watch movies?",
                    Description = "Com que frequencia voce assiste filme?"
                }
            };

            return simplePresents;
        }
    }
}
