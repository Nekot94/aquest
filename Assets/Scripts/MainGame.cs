using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum States
{
    strangeRoom,
    rosmarus,
    anotherDimension,
    fightWithBear,
    goodEnd
}

public class MainGame : MonoBehaviour
{
    public Text mainText;

    private States myState;

    public Image image;

    public Sprite[] images;

    private void Start()
    {
        myState = States.strangeRoom;
    }

    private void Update()
    {
        image.sprite = images[(int) myState];

        if (myState == States.strangeRoom)
            StrangeRoom();
        if (myState == States.rosmarus)
            Rosmarus();
        if (myState == States.anotherDimension)
            AnotherDimension();
        if (myState == States.fightWithBear)
            FightWithBear();
        if (myState == States.goodEnd)
            GoodEnd();
    }

    private void StrangeRoom()
    {
        mainText.text = "Вы в странной комнате. Почему она странная?\n" +
            "В углу комнаты лежит телефон с надписью голосовать за Нэвэльного\n\n" +
            "Голосовать за Нэвэльного (Г)\n" +
            "Подпрыгнуть (П)\n" +
            "";

        if (Input.GetKeyDown(KeyCode.U))
            myState = States.rosmarus;

        if (Input.GetKeyDown(KeyCode.G))
            myState = States.anotherDimension;
    }

    private void Rosmarus()
    {
        mainText.text = "Как только вы голосуете, появляются танцующий морж.\n" +
            "Он плюет бивнем вам в лицо, и вы умираете.\n\n" +
            "КОНЕЦ";
    }

    private void AnotherDimension()
    {
        mainText.text = "Вы прыгаете так высоко, что улетаете в стратосферу и попадаете \n" +
            "в другое измерение." +
            "\n(н)-Присесть за берёзку" +
            "\n(в)-Прыгнуть ещё выше" +
            "\n(ы)-Феличита я вышел на улицу";

        if (Input.GetKeyDown(KeyCode.Y))
            myState = States.strangeRoom;

        if (Input.GetKeyDown(KeyCode.S))
            myState = States.fightWithBear;

        if (Input.GetKeyDown(KeyCode.D))
            myState = States.goodEnd;
    }

    private void FightWithBear()
    {
        mainText.text = "На вас напала курица, вы не пережили";
    }

    private void GoodEnd()
    {
        mainText.text = "Вы улетели в рай. Хорошая коновка.";
    }
}