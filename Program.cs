List < Insult > insults = new List < Insult > ();

insults.Add(new Insult {InsultText = "You look like what morning breath smells like."});
insults.Add(new Insult {InsultText = "If you tried to give me cpr I would probably throw myself back under water."});
insults.Add(new Insult {InsultText = "I am not a fan of you."});
insults.Add(new Insult {InsultText = "You think you're so special...and you are. The fact of your existence is nearly impossible to believe."});
insults.Add(new Insult {InsultText = "I'd rather walk than be on the same plane as you."});
insults.Add(new Insult {InsultText = "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy."});
insults.Add(new Insult {InsultText = "Do you have to be so...like that?"});



List < int > indexes = new List < int > ();

while (indexes.Count < 3) {
    // generate a random number between 0 and the length of the insults list
    int index = new Random().Next(0, insults.Count);

    // if the list of indexes does not contain the random number, add it to the list
    if (!indexes.Contains(index)) {
        indexes.Add(index);
    }
}

for (int i = 0; i < indexes.Count; i++) {
    Console.WriteLine(insults[indexes[i]].InsultText);
}


public class Insult {
    public string InsultText { get; set; } = default!;
}