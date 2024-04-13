using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    // первые три выбора: если хороший выбор, то 1
    // если плохой, то 0
    public static int choice1;
    public static int choice2;
    public static int choice3;
    // final choice в худшем выборе = -4, чтобы отменить сумму
    // всех предыдущих выборов
    // в лучшем = 0
    public static int finalchoice;
}
