using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum States
{
    strangeRoom,
    rosmarus,
    anotherDimension,
    codeWorld,
    street,
    fightWithBear,
    goodEnd
}

public class MainGame : MonoBehaviour
{
    public Text mainText;

    private States myState;

    private void Start()
    {
        myState = States.strangeRoom;
    }

    private void Update()
    {
        if (myState == States.strangeRoom)
            StrangeRoom();
        if (myState == States.rosmarus)
            Rosmarus();
    }

    private void StrangeRoom()
    {
        mainText.text = "Вы в странной комнате. Почему она странная?\n" +
            "В углу комнаты лежит телефон с надписью голосовать за Нэвэльного\n\n" +
            "Голосовать за Нэвэльного (Г)\n" +
            "Подпрыгнуть (П)\n";

        if (Input.GetKeyDown(KeyCode.U))
            myState = States.rosmarus;
    }

    private void Rosmarus()
    {
        mainText.text = "Как только вы голосуете, появляются танцующий морж.\n" +
            "Он плюет бивнем вам в лицо, и вы умираете.\n\n" +
            "КОНЕЦ";
    }



}
