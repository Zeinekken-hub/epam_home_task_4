namespace EpamHometask2
{
    static class PhraseAct
    {
        public const string StartAct = "Лис с журавлем подружились.Даже кумом ему стал, когда у медведицы появился медвежонок.\n" +
                "Вот и вздумал однажды Лис угостить Журавля, пошел звать его к себе в гости:\n" +
                "— Приходи, куманёк, приходи, дорогой! Уж как я тебя угощу!\n";
        public const string BadEnding = "Взяла Лиса досада: думал, что наесться на целую неделю, а домой пошел, как несолоно хлебал.\n " +
                "Как аукнулось, так и откликнулось. С тех пор и дружба у Лиса с Журавлем врозь.\n";
        public const string GoodEnding = "С тех пор и дружба у Лиса с Журавлем стала еще крепче.\n";
        public const string BadCraneEnding = "Взяла Лиса досада: вспомнила как поступила с Журавлем и мучала ее совесть.\n" +
                    "С тех пор Лис стал умнее и чувственее к журавлю";
        public const string BadFoxEnding = "Взяла Лиса досада: думала, что наесться на целую неделю, а домой пошел голодный.\n" +
                    "Не всегда на добро платят добром. С тех пор и дружба у лисы с журавлем врозь.\n";

        public static string UniversalDishAct(string animalOwnerName,
                                              string animalGuestName,
                                              string dishesName,
                                              string foodName,
                                              int phraseNum)
        {
            return phraseNum switch
            {
                1 => $"Идёт {animalGuestName} на званый пир, а {animalOwnerName} наварил " +
                $"такое блюдо как {foodName} и поместил его в {dishesName}. "
                       + $"Подал и угощает:\n",
                2 => $"На другой день приходит {animalGuestName}, а {animalOwnerName} приготовил такое блюдо как {foodName},\n " +
                        $"выложил в {dishesName}, поставил на стол и говорит:\n",
                _ => throw new ActException()
            };
        }

        public static string UniversalEatingAct(string animalOwnerName,
                                                string animalGuestName,
                                                string dishesName,
                                                string foodName,
                                                int phraseNum)
        {
            return phraseNum switch
            {
                1 => $"{animalGuestName} уселся за стол, взял столовые приборы с пасхальным узором и приступил к трапезе\n"
                     + $"паралельно болтая с {animalOwnerName} о дружбе. После того как все доели, {animalOwnerName} говорит:\n",
                2 => $"{animalGuestName} вкусно пообедал с {animalOwnerName}ом и остался довольным."
                     + $"Блюдо {foodName} съедено; лис и говорит:\n",
                3 => $"{animalGuestName} начал вертеться вокруг {dishesName}, и так зайдет и этак, "
                     + $"и лизнет его и понюхает; не вкусно и неудобно есть, не понравилась такая еда!\n ",
                4 => $"{animalGuestName} хлоп-хлоп носом, стучал - стучал, не может нормально есть.\n"
                     + $"В итоге как-то потрепал блюдо, скучно журавлю.\n"
                     + $"{animalOwnerName} и говорит:\n",
                5 => $"{animalGuestName} сел за стол и удивленно посмотрел на своего собеседника. А {animalOwnerName} спрашивает себя\n"
                     + $"- Зачем я такое приготовил? - если мне не понраву.",
                6 => $"{animalOwnerName} ест с невероятным аппетитом свое блюдо, оно ему определенно нравится\n",
                _ => ""
            };
        }

    }
}
