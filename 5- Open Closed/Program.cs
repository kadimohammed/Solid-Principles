


// before

/*List<Question> _questions = Questionnaire.GenererListeDesQuestions();

Examen examen = new Examen(_questions);

examen.Print();*/


// After

using _5__Open_Closed.After;


List<Question> _questions = Questionnaire.GenererListeDesQuestions();

foreach (Question question in _questions)
{
    question.Print();
}
