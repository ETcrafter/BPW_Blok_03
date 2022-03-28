using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    private GameObject RaycastedObject;

    [SerializeField] private int RayLenght = 10;
    [SerializeField] private LayerMask LayerMaskInteract;

    public GameObject Player;
    public Transform TeleportRoom;
    public Transform TeleportHall;
    public Animator Fade;
    public float FadeTime = 1;

    public Animator Magnetron;
    public bool MagnetronOpen;

    public Animator DoorOpening;
    public Animator DoorOpening01;
    public bool DoorOpeningInteract;

    public Animator Door_01;
    public bool Door_01_Open;

    public Animator Door_02;
    public bool Door_02_Open;

    public Animator Door_03;
    public bool Door_03_Open;

    public Animator Kachel;
    public bool KachelOpen;

    public Animator Locker_01;
    public bool Locker01Open;

    public Animator Locker_02;
    public bool Locker02Open;

    public Animator Locker_03;
    public bool Locker03Open;

    public Animator Locker_04;
    public bool Locker04Open;

    public Animator Locker_05;
    public bool Locker05Open;

    public Animator Locker_06;
    public bool Locker06Open;

    public Animator SmeltonBlack;
    public bool BlackInteract;

    public Animator SmeltonPurple;
    public bool PurpleInteract;

    public Animator SmeltonLime;
    public bool LimeInteract;

    public Animator SmeltonDarkBlue;
    public bool DarkBlueInteract;

    public Animator SmeltonPink;
    public bool PinkInteract;

    public Animator SmeltonBlue;
    public bool BlueInteract;

    public Animator SmeltonOrange;
    public bool OrangeInteract;

    public Animator SmeltonWhite;
    public bool WhiteInteract;

    public Animator Jenna;
    public bool JennaInteract;

    public Animator Traveler;
    public bool TravelerInteract;

    public Animator Camilla;
    public bool CamillaInteract;

    public Animator Johnny;
    public bool JohnnyInteract;

    public Animator Burger;
    public bool BurgerInteract;

    public Animator WiiRemote01;
    public bool Wii01Interact;

    public Animator WiiRemote02;
    public bool Wii02Interact;

    public Animator WiiRemote03;
    public bool Wii03Interact;

    public Animator WiiRemote04;
    public bool Wii04Interact;

    public Animator Pan_01;
    public bool Pan_01_Turn;

    public Animator Krukje;
    public bool KrukjeInteract;

    public Animator Stack01;
    public bool Stack01Interact;

    public Animator Stack02;
    public bool Stack02Interact;

    public Animator Glass01;
    public bool Glass01Interact;

    public Animator Flowers;
    public bool FlowersInteract;

    public Animator Plant;
    public bool PlantInteract;

    public Animator PlatesStack01;
    public bool PlatesStack01Interact;

    public Animator PlatesStack02;
    public bool PlatesStack02Interact;

    public Animator Glasses01;
    public bool Glasses01Interact;

    public Animator Glasses02;
    public bool Glasses02Interact;

    public Animator Beers01;
    public bool Beers01Interact;

    public Animator Beers02;
    public bool Beers02Interact;

    public Animator Beers03;
    public bool Beers03Interact;

    public Animator IceTeaSet01;
    public bool IceTeaSet01Interact;

    public Animator IceTeaSet02;
    public bool IceTeaSet02Interact;

    public Animator IceTeaSet03;
    public bool IceTeaSet03Interact;

    public Animator FrameTowodile;
    public bool FrameTowodileInteract;

    public Animator FrameCarby;
    public bool FrameCarbyInteract;

    public Animator FrameDaisy;
    public bool FrameDaisyInteract;

    public Animator FrameSpoop;
    public bool FrameSpoopInteract;

    public Animator FrameTim;
    public bool FrameTimInteract;

    public Animator FrameTeam;
    public bool FrameTeamInteract;

    public Animator FrameNenkers;
    public bool FrameNenkersInteract;

    public Animator FrameGender;
    public bool FrameGenderInteract;

    public Animator FrameSpincent;
    public bool FrameSpincentInteract;

    public Animator FrameCynthia;
    public bool FrameCynthiaInteract;

    public Animator Tree;
    public bool TreeInteract;

    public Animator Wii;
    public bool WiiInteract;

    public Animator Inside01;
    public bool Inside01Interact;

    public Animator Inside02;
    public bool Inside02Interact;

    public Animator Games01;
    public bool Games01Interact;

    public Animator Games02;
    public bool Games02Interact;

    public Animator Games03;
    public bool Games03Interact;

    public Animator Games04;
    public bool Games04Interact;

    public Animator Games05;
    public bool Games05Interact;

    public Animator Games06;
    public bool Games06Interact;

    public Animator Lights;
    public bool LightsInteract;

    void Update()
    {
        MagnetronTotal();

        DoorOpeningTotalTotal();
        Door_01_Rammel();
        Door_02_Rammel();
        Door_03_Rammel();

        KachelTotal();

        Locker01Total();
        Locker02Total();
        Locker03Total();
        Locker04Total();
        Locker05Total();
        Locker06Total();

        JennaTotal();
        JohnnyTotal();
        CamillaTotal();
        TravelerTotal();
        LimeTotal();
        DarkBlueTotal();
        BlackTotal();
        PinkTotal();
        OrangeTotal();
        PurpleTotal();
        BlueTotal();
        WhiteTotal();

        BurgerTotal();

        WiiTotal();
        WiiRemote01Total();
        WiiRemote02Total();
        WiiRemote03Total();
        WiiRemote04Total();

        PanTurn();

        KrukjeTotal();

        Stack01Total();
        Stack02Total();

        Glass01Total();

        FlowersTotal();
        PlantTotal();

        StackOfPlates01Total();
        StackOfPlates02Total();
        Glasses01Total();
        Glasses02Total();
        Beers01Total();
        Beers02Total();
        Beers03Total();
        IceTeaSet01Total();
        IceTeaSet02Total();
        IceTeaSet03Total();

        FrameTowodileTotal();
        FrameCarbyTotal();
        FrameDaisyTotal();
        FrameSpoopTotal();
        FrameTeamTotal();
        FrameTimTotal();
        FrameCynthiaTotal();
        FrameNenkersTotal();
        FrameGenderTotal();
        FrameSpincentTotal();

        TreeTotal();

        Inside01Total();
        Inside02Total();

        Games01Total();
        Games02Total();
        Games03Total();
        Games04Total();
        Games05Total();
        Games06Total();
    }


    void DoorOpeningTotalTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (DoorOpeningInteract == false && hit.collider.CompareTag("DoorOpening"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Fade.SetBool("Interact", true);

                    DoorOpening01.SetBool("Interact", true);
                    DoorOpening.SetBool("Interact", true);
                    Debug.Log("Door Open Yes");

                    StartCoroutine(ToRoom());

                    DoorOpeningInteract = true;
                }
            }
            else if (DoorOpeningInteract == true && hit.collider.CompareTag("DoorOpening"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Fade.SetBool("Interact", false);

                    DoorOpening01.SetBool("Interact", false);
                    DoorOpening.SetBool("Interact", false);
                    Debug.Log("Door Open Yes");

                    StartCoroutine(ToHall());

                    DoorOpeningInteract = false;
                }
            }
        }
    }

    IEnumerator ToHall()
    {
        yield return new WaitForSeconds(FadeTime);
        Player.transform.position = TeleportHall.transform.position;
        
    }

    IEnumerator ToRoom()
    {
        yield return new WaitForSeconds(FadeTime);
        Player.transform.position = TeleportRoom.transform.position;
        
    }

    void Games01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Games01Interact == false && hit.collider.CompareTag("Games_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Games01.SetBool("Interact", true);
                    Debug.Log("Games Yes");
                    Games01Interact = true;
                }
            }

            else if (Games01Interact == true && hit.collider.CompareTag("Games_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Games01.SetBool("Interact", false);
                    Debug.Log("Games No");
                    Games01Interact = false;
                }
            }
        }
    }

    void Games02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Games02Interact == false && hit.collider.CompareTag("Games_02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Games02.SetBool("Interact", true);
                    Debug.Log("Games Yes");
                    Games02Interact = true;
                }
            }

            else if (Games02Interact == true && hit.collider.CompareTag("Games_02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Games02.SetBool("Interact", false);
                    Debug.Log("Games No");
                    Games02Interact = false;
                }
            }
        }
    }

    void Games03Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Games03Interact == false && hit.collider.CompareTag("Games_03"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Games03.SetBool("Interact", true);
                    Debug.Log("Games Yes");
                    Games03Interact = true;
                }
            }

            else if (Games03Interact == true && hit.collider.CompareTag("Games_03"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Games03.SetBool("Interact", false);
                    Debug.Log("Games No");
                    Games03Interact = false;
                }
            }
        }
    }

    void Games04Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Games04Interact == false && hit.collider.CompareTag("Games_04"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Games04.SetBool("Interact", true);
                    Debug.Log("Games Yes");
                    Games04Interact = true;
                }
            }

            else if (Games04Interact == true && hit.collider.CompareTag("Games_04"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Games04.SetBool("Interact", false);
                    Debug.Log("Games No");
                    Games04Interact = false;
                }
            }
        }
    }

    void Games05Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Games05Interact == false && hit.collider.CompareTag("Games_05"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Games05.SetBool("Interact", true);
                    Debug.Log("Games Yes");
                    Games05Interact = true;
                }
            }

            else if (Games05Interact == true && hit.collider.CompareTag("Games_05"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Games05.SetBool("Interact", false);
                    Debug.Log("Games No");
                    Games05Interact = false;
                }
            }
        }
    }

    void Games06Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Games06Interact == false && hit.collider.CompareTag("Games_06"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Games06.SetBool("Interact", true);
                    Debug.Log("Games Yes");
                    Games06Interact = true;
                }
            }

            else if (Games06Interact == true && hit.collider.CompareTag("Games_06"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Games06.SetBool("Interact", false);
                    Debug.Log("Games No");
                    Games06Interact = false;
                }
            }
        }
    }

    void Inside01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Inside01Interact == false && hit.collider.CompareTag("Inside_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Inside01.SetBool("Interact", true);
                    Debug.Log("Pans Yes");
                    Inside01Interact = true;
                }
            }

            else if (Inside01Interact == true && hit.collider.CompareTag("Inside_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Inside01.SetBool("Interact", false);
                    Debug.Log("Pans No");
                    Inside01Interact = false;
                }
            }
        }
    }

    void Inside02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Inside02Interact == false && hit.collider.CompareTag("Inside_02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Inside02.SetBool("Interact", true);
                    Debug.Log("Pans Yes");
                    Inside02Interact = true;
                }
            }

            else if (Inside02Interact == true && hit.collider.CompareTag("Inside_02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Inside02.SetBool("Interact", false);
                    Debug.Log("Pans No");
                    Inside02Interact = false;
                }
            }
        }
    }

    void FlowersTotal()
            {
                RaycastHit hit;
                Vector3 Forward = transform.TransformDirection(Vector3.forward);

                if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
                {
                    if (FlowersInteract == false && hit.collider.CompareTag("Flowers"))
                    {
                        RaycastedObject = hit.collider.gameObject;

                        if (Input.GetKeyDown("e"))
                        {
                            Flowers.SetBool("Interact", true);
                            Debug.Log("Door Open Yes");
                            FlowersInteract = true;
                        }
                    }

                    else if (FlowersInteract == true && hit.collider.CompareTag("Flowers"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Flowers.SetBool("Interact", false);
                    Debug.Log("Door Open No");
                    FlowersInteract = false;
                }
            }
        }
    }

    void WiiTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (WiiInteract == false && hit.collider.CompareTag("Wii"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Wii.SetBool("Interact", true);
                    Debug.Log("Wii Yes");
                    WiiInteract = true;
                }


            }
            else if (WiiInteract == true && hit.collider.CompareTag("Wii"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Wii.SetBool("Interact", false);
                    Debug.Log("Wii No");
                    WiiInteract = false;
                }
            }
        }
    }

    void TreeTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (TreeInteract == false && hit.collider.CompareTag("Tree"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Tree.SetBool("Interact", true);
                    Debug.Log("Tree Yes");
                    TreeInteract = true;
                }


            }
            else if (TreeInteract == true && hit.collider.CompareTag("Tree"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Tree.SetBool("Interact", false);
                    Debug.Log("Tree No");
                    TreeInteract = false;
                }
            }
        }
    }

    void IceTeaSet01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (IceTeaSet01Interact == false && hit.collider.CompareTag("IceTea_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    IceTeaSet01.SetBool("Interact", true);
                    Debug.Log("Beers Yes");
                    IceTeaSet01Interact = true;
                }


            }
            else if (IceTeaSet01Interact == true && hit.collider.CompareTag("IceTea_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    IceTeaSet01.SetBool("Interact", false);
                    Debug.Log("Beers No");
                    IceTeaSet01Interact = false;
                }
            }
        }
    }

    void IceTeaSet02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (IceTeaSet02Interact == false && hit.collider.CompareTag("IceTea_02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    IceTeaSet02.SetBool("Interact", true);
                    Debug.Log("IceTea Yes");
                    IceTeaSet02Interact = true;
                }


            }
            else if (IceTeaSet02Interact == true && hit.collider.CompareTag("IceTea_02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    IceTeaSet02.SetBool("Interact", false);
                    Debug.Log("IceTea No");
                    IceTeaSet02Interact = false;
                }
            }
        }
    }

    void IceTeaSet03Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (IceTeaSet03Interact == false && hit.collider.CompareTag("IceTea_03"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    IceTeaSet03.SetBool("Interact", true);
                    Debug.Log("IceTea Yes");
                    IceTeaSet03Interact = true;
                }


            }
            else if (IceTeaSet03Interact == true && hit.collider.CompareTag("IceTea_03"))
            {
                if (Input.GetKeyDown("e"))
                {
                    IceTeaSet03.SetBool("Interact", false);
                    Debug.Log("IceTea No");
                    IceTeaSet03Interact = false;
                }
            }
        }
    }

    void FrameTimTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameTimInteract == false && hit.collider.CompareTag("Frame04"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameTim.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameTimInteract = true;
                }


            }
            else if (FrameTimInteract == true && hit.collider.CompareTag("Frame04"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameTim.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameTimInteract = false;
                }
            }
        }
    }

    void FrameSpincentTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameSpincentInteract == false && hit.collider.CompareTag("Frame07"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameSpincent.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameSpincentInteract = true;
                }


            }
            else if (FrameSpincentInteract == true && hit.collider.CompareTag("Frame07"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameSpincent.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameSpincentInteract = false;
                }
            }
        }
    }

    void FrameSpoopTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameSpoopInteract == false && hit.collider.CompareTag("Frame05"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameSpoop.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameSpoopInteract = true;
                }


            }
            else if (FrameSpoopInteract == true && hit.collider.CompareTag("Frame05"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameSpoop.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameSpoopInteract = false;
                }
            }
        }
    }

    void FrameCynthiaTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameCynthiaInteract == false && hit.collider.CompareTag("Frame09"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameCynthia.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameCynthiaInteract = true;
                }


            }
            else if (FrameCynthiaInteract == true && hit.collider.CompareTag("Frame09"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameCynthia.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameCynthiaInteract = false;
                }
            }
        }
    }

    void FrameNenkersTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameNenkersInteract == false && hit.collider.CompareTag("Frame10"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameNenkers.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameNenkersInteract = true;
                }


            }
            else if (FrameNenkersInteract == true && hit.collider.CompareTag("Frame10"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameNenkers.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameNenkersInteract = false;
                }
            }
        }
    }

    void FrameGenderTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameGenderInteract == false && hit.collider.CompareTag("Frame08"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameGender.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameGenderInteract = true;
                }


            }
            else if (FrameGenderInteract == true && hit.collider.CompareTag("Frame08"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameGender.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameGenderInteract = false;
                }
            }
        }
    }

    void FrameTeamTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameTeamInteract == false && hit.collider.CompareTag("Frame06"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameTeam.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameTeamInteract = true;
                }


            }
            else if (FrameTeamInteract == true && hit.collider.CompareTag("Frame06"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameTeam.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameTeamInteract = false;
                }
            }
        }
    }

    void FrameDaisyTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameDaisyInteract == false && hit.collider.CompareTag("Frame03"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameDaisy.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameDaisyInteract = true;
                }


            }
            else if (FrameDaisyInteract == true && hit.collider.CompareTag("Frame03"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameDaisy.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameDaisyInteract = false;
                }
            }
        }
    }

    void FrameCarbyTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameCarbyInteract == false && hit.collider.CompareTag("Frame02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameCarby.SetBool("Interact", true);
                    Debug.Log("Frame Yes");
                    FrameCarbyInteract = true;
                }


            }
            else if (FrameCarbyInteract == true && hit.collider.CompareTag("Frame02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameCarby.SetBool("Interact", false);
                    Debug.Log("Frame No");
                    FrameCarbyInteract = false;
                }
            }
        }
    }

    void FrameTowodileTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (FrameTowodileInteract == false && hit.collider.CompareTag("Frame01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    FrameTowodile.SetBool("Interact", true);
                    Debug.Log("Beers Yes");
                    FrameTowodileInteract = true;
                }


            }
            else if (FrameTowodileInteract == true && hit.collider.CompareTag("Frame01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    FrameTowodile.SetBool("Interact", false);
                    Debug.Log("Beers No");
                    FrameTowodileInteract = false;
                }
            }
        }
    }

    void Beers01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Beers01Interact == false && hit.collider.CompareTag("Beers01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Beers01.SetBool("Interact", true);
                    Debug.Log("Beers Yes");
                    Beers01Interact = true;
                }


            }
            else if (Beers01Interact == true && hit.collider.CompareTag("Beers01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Beers01.SetBool("Interact", false);
                    Debug.Log("Beers No");
                    Beers01Interact = false;
                }
            }
        }
    }

    void Beers02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Beers02Interact == false && hit.collider.CompareTag("Beers02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Beers02.SetBool("Interact", true);
                    Debug.Log("Beers Yes");
                    Beers02Interact = true;
                }


            }
            else if (Beers02Interact == true && hit.collider.CompareTag("Beers02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Beers02.SetBool("Interact", false);
                    Debug.Log("Beers No");
                    Beers02Interact = false;
                }
            }
        }
    }

    void Beers03Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Beers03Interact == false && hit.collider.CompareTag("Beers03"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Beers03.SetBool("Interact", true);
                    Debug.Log("Beers Yes");
                    Beers03Interact = true;
                }


            }
            else if (Beers03Interact == true && hit.collider.CompareTag("Beers03"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Beers03.SetBool("Interact", false);
                    Debug.Log("Beers No");
                    Beers03Interact = false;
                }
            }
        }
    }

    void Glasses01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Glasses01Interact == false && hit.collider.CompareTag("Glasses01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Glasses01.SetBool("Interact", true);
                    Debug.Log("Flass Yes");
                    Glasses01Interact = true;
                }


            }
            else if (Glasses01Interact == true && hit.collider.CompareTag("Glasses01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Glasses01.SetBool("Interact", false);
                    Debug.Log("Glass No");
                    Glasses01Interact = false;
                }
            }
        }
    }

    void Glasses02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Glasses02Interact == false && hit.collider.CompareTag("Glasses02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Glasses02.SetBool("Interact", true);
                    Debug.Log("Glass Yes");
                    Glasses02Interact = true;
                }


            }
            else if (Glasses02Interact == true && hit.collider.CompareTag("Glasses02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Glasses02.SetBool("Interact", false);
                    Debug.Log("Glass No");
                    Glasses02Interact = false;
                }
            }
        }
    }

    void StackOfPlates01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (PlatesStack01Interact == false && hit.collider.CompareTag("Plates01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    PlatesStack01.SetBool("Interact", true);
                    Debug.Log("Plan Yes");
                    PlatesStack01Interact = true;
                }


            }
            else if (PlatesStack01Interact == true && hit.collider.CompareTag("Plates01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    PlatesStack01.SetBool("Interact", false);
                    Debug.Log("Plant No");
                    PlatesStack01Interact = false;
                }
            }
        }
    }

    void StackOfPlates02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (PlatesStack02Interact == false && hit.collider.CompareTag("Plates_02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    PlatesStack02.SetBool("Interact", true);
                    Debug.Log("Plates Yes");
                    PlatesStack02Interact = true;
                }


            }
            else if (PlatesStack02Interact == true && hit.collider.CompareTag("Plates_02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    PlatesStack02.SetBool("Interact", false);
                    Debug.Log("Plates No");
                    PlatesStack02Interact = false;
                }
            }
        }
    }

    void PlantTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (PlantInteract == false && hit.collider.CompareTag("Plant"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Plant.SetBool("Interact", true);
                    Debug.Log("Plan Yes");
                    PlantInteract = true;
                }


            }
            else if (PlantInteract == true && hit.collider.CompareTag("Plant"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Plant.SetBool("Interact", false);
                    Debug.Log("Plant No");
                    PlantInteract = false;
                }
            }
        }
    }

    void Stack01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Stack01Interact == false && hit.collider.CompareTag("Stack_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Stack01.SetBool("Interact", true);
                    Debug.Log("Stack01 Yes");
                    Stack01Interact = true;
                }


            }
            else if (Stack01Interact == true && hit.collider.CompareTag("Stack_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Stack01.SetBool("Interact", false);
                    Debug.Log("Stack01 No");
                    Stack01Interact = false;
                }
            }
        }
    }

    void Stack02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Stack02Interact == false && hit.collider.CompareTag("Stack_02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Stack02.SetBool("Interact", true);
                    Debug.Log("Stack02 Yes");
                    Stack02Interact = true;
                }


            }
            else if (Stack02Interact == true && hit.collider.CompareTag("Stack_02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Stack02.SetBool("Interact", false);
                    Debug.Log("Stack02 No");
                    Stack02Interact = false;
                }
            }
        }
    }

    void Glass01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Glass01Interact == false && hit.collider.CompareTag("Glass_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Glass01.SetBool("Interact", true);
                    Debug.Log("Glass Yes");
                    Glass01Interact = true;
                }


            }
            else if (Glass01Interact == true && hit.collider.CompareTag("Glass_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Glass01.SetBool("Interact", false);
                    Debug.Log("Glass No");
                    Glass01Interact = false;
                }
            }
        }
    }

    

    void KrukjeTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (KrukjeInteract == false && hit.collider.CompareTag("Krukje"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Krukje.SetBool("Interact", true);
                    Debug.Log("Krukje Interact 01");
                    KrukjeInteract = true;
                }


            }
            else if (KrukjeInteract == true && hit.collider.CompareTag("Krukje"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Krukje.SetBool("Interact", false);
                    Debug.Log("Krukje Interact 02");
                    KrukjeInteract = false;
                }
            }
        }
    }

    void JennaTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (JennaInteract == false && hit.collider.CompareTag("Jenna"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Jenna.SetBool("Interact", true);
                    Debug.Log("Jenna Interact 01");
                    JennaInteract = true;
                }


            }
            else if (JennaInteract == true && hit.collider.CompareTag("Jenna"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Jenna.SetBool("Interact", false);
                    Debug.Log("Jenna Interact 02");
                    JennaInteract = false;
                }
            }
        }
    }

    void JohnnyTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (JohnnyInteract == false && hit.collider.CompareTag("Johnny"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Johnny.SetBool("Interact", true);
                    Debug.Log("Johnny Interact 01");
                    JohnnyInteract = true;
                }


            }
            else if (JohnnyInteract == true && hit.collider.CompareTag("Johnny"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Johnny.SetBool("Interact", false);
                    Debug.Log("Johnny Interact 02");
                    JohnnyInteract = false;
                }
            }
        }
    }

    void TravelerTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (TravelerInteract == false && hit.collider.CompareTag("Traveler"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Traveler.SetBool("Interact", true);
                    Debug.Log("Traveler Interact 01");
                    TravelerInteract = true;
                }


            }
            else if (TravelerInteract == true && hit.collider.CompareTag("Traveler"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Traveler.SetBool("Interact", false);
                    Debug.Log("Traveler Interact 02");
                   TravelerInteract = false;
                }
            }
        }
    }

    void PanTurn()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Pan_01_Turn == false && hit.collider.CompareTag("Pan_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Pan_01.SetBool("Turn", true);
                    Debug.Log("Pan Twist Right");
                    Pan_01_Turn = true;
                }


            }
            else if (Pan_01_Turn == true && hit.collider.CompareTag("Pan_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Pan_01.SetBool("Turn", false);
                    Debug.Log("Pan Twist Left");
                    Pan_01_Turn = false;
                }
            }
        }
    }

    void WiiRemote01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Wii01Interact == false && hit.collider.CompareTag("WiiRemote_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    WiiRemote01.SetBool("Interact", true);
                    Debug.Log("Remote_01 Yes");
                    Wii01Interact = true;
                }


            }
            else if (Wii01Interact == true && hit.collider.CompareTag("WiiRemote_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    WiiRemote01.SetBool("Interact", false);
                    Debug.Log("Remote_01 No");
                    Wii01Interact = false;
                }
            }
        }
    }

    void WiiRemote02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Wii02Interact == false && hit.collider.CompareTag("WiiRemote_02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    WiiRemote02.SetBool("Interact", true);
                    Debug.Log("Remote_02 Yes");
                    Wii02Interact = true;
                }


            }
            else if (Wii02Interact == true && hit.collider.CompareTag("WiiRemote_02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    WiiRemote02.SetBool("Interact", false);
                    Debug.Log("Remote_02 No");
                    Wii02Interact = false;
                }
            }
        }
    }

    void WiiRemote03Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Wii03Interact == false && hit.collider.CompareTag("WiiRemote_03"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    WiiRemote03.SetBool("Interact", true);
                    Debug.Log("Remote_03 Yes");
                    Wii03Interact = true;
                }


            }
            else if (Wii03Interact == true && hit.collider.CompareTag("WiiRemote_03"))
            {
                if (Input.GetKeyDown("e"))
                {
                    WiiRemote03.SetBool("Interact", false);
                    Debug.Log("Remote_03 No");
                    Wii03Interact = false;
                }
            }
        }
    }

    void WiiRemote04Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Wii04Interact == false && hit.collider.CompareTag("WiiRemote_04"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    WiiRemote04.SetBool("Interact", true);
                    Debug.Log("Remote_04 Yes");
                    Wii04Interact = true;
                }


            }
            else if (Wii04Interact == true && hit.collider.CompareTag("WiiRemote_04"))
            {
                if (Input.GetKeyDown("e"))
                {
                    WiiRemote04.SetBool("Interact", false);
                    Debug.Log("Remote_04 No");
                    Wii04Interact = false;
                }
            }
        }
    }

    void PurpleTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (PurpleInteract == false && hit.collider.CompareTag("Window"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Lights.SetBool("Interact", true);
                    SmeltonPurple.SetBool("Interact", true);
                    Debug.Log("WindowHasBeenTouched_01");
                    PurpleInteract = true;
                }
            }
            else if (PurpleInteract == true && hit.collider.CompareTag("Window"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Lights.SetBool("Interact", false);
                    SmeltonPurple.SetBool("Interact", false);
                    Debug.Log("WindowHasBeenTouched_01");
                    PurpleInteract = false;
            }
            }
        }
    }

    void BlueTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (BlueInteract == false && hit.collider.CompareTag("SmeltonBlue"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    SmeltonBlue.SetBool("Interact", true);
                    Debug.Log("Blue_01");
                    BlueInteract = true;
                }


            }
            else if (BlueInteract == true && hit.collider.CompareTag("SmeltonBlue"))
            {
                if (Input.GetKeyDown("e"))
                {
                    SmeltonBlue.SetBool("Interact", false);
                    Debug.Log("Blue_02");
                    BlueInteract = false;
                }
            }
        }
    }

    void WhiteTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (WhiteInteract == false && hit.collider.CompareTag("SmeltonWhite"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    SmeltonWhite.SetBool("Interact", true);
                    Debug.Log("White_01");
                    WhiteInteract = true;
                }


            }
            else if (WhiteInteract == true && hit.collider.CompareTag("SmeltonWhite"))
            {
                if (Input.GetKeyDown("e"))
                {
                    SmeltonWhite.SetBool("Interact", false);
                    Debug.Log("Whit_02");
                    WhiteInteract = false;
                }
            }
        }
    }

    void OrangeTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (OrangeInteract == false && hit.collider.CompareTag("SmeltonOrange"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    SmeltonOrange.SetBool("Interact", true);
                    Debug.Log("Orange_01");
                    OrangeInteract = true;
                }


            }
            else if (OrangeInteract == true && hit.collider.CompareTag("SmeltonOrange"))
            {
                if (Input.GetKeyDown("e"))
                {
                    SmeltonOrange.SetBool("Interact", false);
                    Debug.Log("Orange_02");
                    OrangeInteract = false;
                }
            }
        }
    }

    void BlackTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (BlackInteract == false && hit.collider.CompareTag("SmeltonBlack"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    SmeltonBlack.SetBool("Interact", true);
                    Debug.Log("Black_01");
                    BlackInteract = true;
                }


            }
            else if (BlackInteract == true && hit.collider.CompareTag("SmeltonBlack"))
            {
                if (Input.GetKeyDown("e"))
                {
                    SmeltonBlack.SetBool("Interact", false);
                    Debug.Log("Black_02");
                    BlackInteract = false;
                }
            }
        }
    }

    void PinkTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (PinkInteract == false && hit.collider.CompareTag("SmeltonPink"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    SmeltonPink.SetBool("Interact", true);
                    Debug.Log("Pink_01");
                    PinkInteract = true;
                }


            }
            else if (PinkInteract == true && hit.collider.CompareTag("SmeltonPink"))
            {
                if (Input.GetKeyDown("e"))
                {
                    SmeltonPink.SetBool("Interact", false);
                    Debug.Log("Pink_02");
                    PinkInteract = false;
                }
            }
        }
    }

    void DarkBlueTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (DarkBlueInteract == false && hit.collider.CompareTag("SmeltonDarkBlue"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    SmeltonDarkBlue.SetBool("Interact", true);
                    Debug.Log("DarkBlue_01");
                    DarkBlueInteract = true;
                }


            }
            else if (DarkBlueInteract == true && hit.collider.CompareTag("SmeltonDarkBlue"))
            {
                if (Input.GetKeyDown("e"))
                {
                    SmeltonDarkBlue.SetBool("Interact", false);
                    Debug.Log("DarkBlue_02");
                    DarkBlueInteract = false;
                }
            }
        }
    }

    void LimeTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (LimeInteract == false && hit.collider.CompareTag("SmeltonLime"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    SmeltonLime.SetBool("SmeltonInteract", true);
                    Debug.Log("Lime_01");
                    LimeInteract = true;
                }


            }
            else if (LimeInteract == true && hit.collider.CompareTag("SmeltonLime"))
            {
                if (Input.GetKeyDown("e"))
                {
                    SmeltonLime.SetBool("SmeltonInteract", false);
                    Debug.Log("Lime_02");
                    LimeInteract = false;
                }
            }
        }
    }

    void CamillaTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (CamillaInteract == false && hit.collider.CompareTag("Camilla"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Camilla.SetBool("Interact", true);
                    Debug.Log("Camilla_01");
                    CamillaInteract = true;
                }


            }
            else if (CamillaInteract == true && hit.collider.CompareTag("Camilla"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Camilla.SetBool("Interact", false);
                    Debug.Log("Camilla_02");
                    CamillaInteract = false;
                }
            }
        }
    }

    void BurgerTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (BurgerInteract == false && hit.collider.CompareTag("Burger"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Burger.SetBool("BurgerInteract", true);
                    Debug.Log("Burger_01");
                    BurgerInteract = true;
                }


            }
            else if (BurgerInteract == true && hit.collider.CompareTag("Burger"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Burger.SetBool("BurgerInteract", false);
                    Debug.Log("Burger_02");
                    BurgerInteract = false;
                }
            }
        }
    }

    void Locker01Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Locker01Open == false && hit.collider.CompareTag("Locker_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Locker_01.SetBool("DoorOpen", true);
                    Debug.Log("Locker_01 Open");
                    Locker01Open = true;
                }


            }
            else if (Locker01Open == true && hit.collider.CompareTag("Locker_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Locker_01.SetBool("DoorOpen", false);
                    Debug.Log("Locker_01 Close");
                    Locker01Open = false;
                }
            }
        }
    }

    void Locker02Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Locker02Open == false && hit.collider.CompareTag("Locker_02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Locker_02.SetBool("DoorOpen", true);
                    Debug.Log("Locker_02 Open");
                    Locker02Open = true;
                }


            }
            else if (Locker02Open == true && hit.collider.CompareTag("Locker_02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Locker_02.SetBool("DoorOpen", false);
                    Debug.Log("Locker_02 Close");
                    Locker02Open = false;
                }
            }
        }
    }

    void Locker03Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Locker03Open == false && hit.collider.CompareTag("Locker_03"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Locker_03.SetBool("DoorOpen", true);
                    Debug.Log("Locker_03 Open");
                    Locker03Open = true;
                }


            }
            else if (Locker03Open == true && hit.collider.CompareTag("Locker_03"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Locker_03.SetBool("DoorOpen", false);
                    Debug.Log("Locker_03 Close");
                    Locker03Open = false;
                }
            }
        }
    }

    void Locker04Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Locker04Open == false && hit.collider.CompareTag("Locker_04"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Locker_04.SetBool("DoorOpen", true);
                    Debug.Log("Locker_04 Open");
                    Locker04Open = true;
                }


            }
            else if (Locker04Open == true && hit.collider.CompareTag("Locker_04"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Locker_04.SetBool("DoorOpen", false);
                    Debug.Log("Locker_04 Close");
                    Locker04Open = false;
                }
            }
        }
    }

    void Locker05Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Locker05Open == false && hit.collider.CompareTag("Locker_05"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Locker_05.SetBool("DoorOpen", true);
                    Debug.Log("Locker_05 Open");
                    Locker05Open = true;
                }


            }
            else if (Locker05Open == true && hit.collider.CompareTag("Locker_05"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Locker_05.SetBool("DoorOpen", false);
                    Debug.Log("Locker_05 Close");
                    Locker05Open = false;
                }
            }
        }
    }

    void Locker06Total()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Locker06Open == false && hit.collider.CompareTag("Locker_06"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Locker_06.SetBool("DoorOpen", true);
                    Debug.Log("Locker_06 Open");
                    Locker06Open = true;
                }


            }
            else if (Locker06Open == true && hit.collider.CompareTag("Locker_06"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Locker_06.SetBool("DoorOpen", false);
                    Debug.Log("Locker_06 Close");
                    Locker06Open = false;
                }
            }
        }
    }

    void Door_01_Rammel()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Door_01_Open == false && hit.collider.CompareTag("Door_01"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Door_01.SetBool("TouchedDoor", true);
                    Debug.Log("Rammel_02");
                    Door_01_Open = true;
                }


            }
            else if (Door_01_Open == true && hit.collider.CompareTag("Door_01"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Door_01.SetBool("TouchedDoor", false);
                    Debug.Log("Rammel_01");
                    Door_01_Open = false;
                }
            }
        }
    }

    void Door_02_Rammel()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Door_02_Open == false && hit.collider.CompareTag("Door_02"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Door_02.SetBool("TouchedDoor", true);
                    Debug.Log("Rammel_02");
                    Door_02_Open = true;
                }


            }
            else if (Door_02_Open == true && hit.collider.CompareTag("Door_02"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Door_02.SetBool("TouchedDoor", false);
                    Debug.Log("Rammel_02");
                    Door_02_Open = false;
                }
            }
        }
    }

    void Door_03_Rammel()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (Door_03_Open == false && hit.collider.CompareTag("Door_03"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Door_03.SetBool("TouchedDoor", true);
                    Debug.Log("Rammel_01");
                    Door_03_Open = true;
                }


            }
            else if (Door_03_Open == true && hit.collider.CompareTag("Door_03"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Door_03.SetBool("TouchedDoor", false);
                    Debug.Log("Rammel_02");
                    Door_03_Open = false;
                }
            }
        }
    }

    void KachelTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (KachelOpen == false && hit.collider.CompareTag("Kachel"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Kachel.SetBool("DoorOpen", true);
                    Debug.Log("Kachel Open");
                    KachelOpen = true;
                }


            }
            else if (KachelOpen == true && hit.collider.CompareTag("Kachel"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Kachel.SetBool("DoorOpen", false);
                    Debug.Log("Kachel Close");
                    KachelOpen = false;
                }
            }
        }
    }

    void MagnetronTotal()
    {
        RaycastHit hit;
        Vector3 Forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Forward, out hit, RayLenght, LayerMaskInteract.value))
        {
            if (MagnetronOpen == false && hit.collider.CompareTag("Magnetron"))
            {
                RaycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Magnetron.SetBool("MagnetronOpen", true);
                    Debug.Log("Magnetron Gaat Open");
                    MagnetronOpen = true;
                }


            }
            else if (MagnetronOpen == true && hit.collider.CompareTag("Magnetron"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Magnetron.SetBool("MagnetronOpen", false);
                    Debug.Log("Magnetron Gaat Dicht");
                    MagnetronOpen = false;
                }
            }
        }
    }
}
