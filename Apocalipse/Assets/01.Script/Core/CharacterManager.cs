using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CharacterManager : BaseManager
{
    [SerializeField]
    private BaseCharacter _player;
    public BaseCharacter Player => _player;

    public override void Init(GameManager gameManager)
    {
        base.Init(gameManager);
        _player.Init(this);
    }
}