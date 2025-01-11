using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Linq;
using TMPro;
using UnityEngine.Events;

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            ModAPI.RegisterCategory("Squid Game Mod", "Items from the mod \"Squid Game\"", 
            ModAPI.LoadSprite("assets/logo.png"));

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Magnum Revolver"),
                    NameOverride = "Revolver [Squid Game]",
                    DescriptionOverride = "Regular revolver",
                    CategoryOverride = ModAPI.FindCategory("Squid Game Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("assets/miniatures/Revolver.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("assets/weopons/Revolver.png");
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
                        Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                        customCartridge.name = "ExampleCartridge";
                        customCartridge.Damage *= 0.11f;
                        customCartridge.StartSpeed *= 457368f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 1.4f;
                        customCartridge.Recoil *= 1.5f;
                        customCartridge.ImpactForce *= 0f;
                        firearm.Cartridge = customCartridge;

                        var boxCollider = Instance.gameObject.AddComponent<BoxCollider>();
                        boxCollider.size = new Vector3(1f, 0.5f, 0.2f);
                        boxCollider.center = new Vector3(0, 0, 0);
                        
                        Instance.FixColliders(); 
                    }
                }
            );

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Submachine Gun"),
                    NameOverride = "MP5A3 [Squid Game]",
                    DescriptionOverride = "",
                    CategoryOverride = ModAPI.FindCategory("Squid Game Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("assets/miniatures/MP5A3.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("assets/weopons/MP5A3.png");
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
                        Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                        customCartridge.name = "ExampleCartridge";
                        customCartridge.Damage *= 0.1f;
                        customCartridge.StartSpeed *= 457368f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 1.4f;
                        customCartridge.Recoil *= 1.2f;
                        customCartridge.ImpactForce *= 0f;
                        firearm.Cartridge = customCartridge;

                        var boxCollider = Instance.gameObject.AddComponent<BoxCollider>();
                        boxCollider.size = new Vector3(1f, 0.5f, 0.2f);
                        boxCollider.center = new Vector3(0, 0, 0);

                        Instance.FixColliders(); 
                    }
                }
            );

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Frontman",
                    DescriptionOverride = "Almost nothing is known about him",
                    CategoryOverride = ModAPI.FindCategory("Squid Game Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("assets/miniatures/Frontman.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("assets/characters/Frontman.png");
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, null, null, 1);
                    }
                }
            );

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Manager | ☐",
                    DescriptionOverride = "Сommanders who act under direct orders from the Frontman and officer.",
                    CategoryOverride = ModAPI.FindCategory("Squid Game Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("assets/miniatures/Manager.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("assets/characters/Manager.png");
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, null, null, 1);
                        
                    }
                }
            );

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Soldier | △",
                    DescriptionOverride = "Armed security forces who eliminate eliminated players and prevent participants from breaking the rules of the Game.",
                    CategoryOverride = ModAPI.FindCategory("Squid Game Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("assets/miniatures/Soldier.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("assets/characters/Soldier.png");
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, null, null, 1);
                        
                    }
                }
            );

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Worker | ◯",
                    DescriptionOverride = "They are tasked with menial tasks such as corpse disposal, game preparation, maintenance, and food distribution.",
                    CategoryOverride = ModAPI.FindCategory("Squid Game Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("assets/miniatures/Worker.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("assets/characters/Worker.png");
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, null, null, 1);
                        
                    }
                }
            );

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Officer | ☐",
                    DescriptionOverride = "Deputy Frontman",
                    CategoryOverride = ModAPI.FindCategory("Squid Game Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("assets/miniatures/Officer.png"),
                    AfterSpawn = (Instance) =>
                    { 
                        var skin = ModAPI.LoadTexture("assets/characters/Officer.png");
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, null, null, 1);
                        
                    }
                }
            );
        }
    };
}
