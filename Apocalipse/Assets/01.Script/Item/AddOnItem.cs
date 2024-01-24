using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOnItem : BaseItem
{
    public override void OnGetItem(CharacterManager characterManager)
    {
        base.OnGetItem(characterManager);

        PlayerCharacter Player = characterManager.Player.GetComponent<PlayerCharacter>();

        if (GameInstance.instance.CurrentPlayerAddOnCount >= Player.MaxAddOnCount)
            return;

        Transform addOnspawnTransform = Player.AddOnTransform[GameInstance.instance.CurrentPlayerAddOnCount];
        SpawnAddOn(addOnspawnTransform.position, Player.AddOnPrefab, addOnspawnTransform);
        GameInstance.instance.CurrentPlayerAddOnCount++;    
    }

    public static void SpawnAddOn(Vector3 position, GameObject prefab, Transform addOnTargetTransform)
    {
        GameObject AddOnInstance = Instantiate(prefab, position, Quaternion.identity);
        AddOnInstance.GetComponent<AddOn>().FollowTargetTransform = addOnTargetTransform;
    }
}
