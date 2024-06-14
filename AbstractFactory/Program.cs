using AbstractFactory;
using AbstractFactory.Interfaces;

IAbstractFactory romanFactory = new RomanFactory();

IUnit romanMelee = romanFactory.CreateMeleeUnit();
IUnit romanRanged = romanFactory.CreateRangedUnit();
IBuilding romanBarrack = romanFactory.CreateBarracks();
IBuilding romanRangeBarrack = romanFactory.CreateRangedBarrack();

IAbstractFactory greekFactory = new GreekFactory();

IUnit greekMelee = greekFactory.CreateMeleeUnit();
IUnit greekRanged = greekFactory.CreateRangedUnit();
IBuilding greekBarrack = greekFactory.CreateBarracks();
IBuilding greekRangeBarrack = greekFactory.CreateRangedBarrack();

romanMelee.Move();
romanRanged.Move();
romanBarrack.CreateUnits();
romanRangeBarrack.CreateUnits();

greekMelee.Move();
greekRanged.Move();
greekBarrack.CreateUnits();
greekRangeBarrack.CreateUnits();

Console.ReadKey();
