using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PeriodicTable : MonoBehaviour
{
    public Text Symbol;
    public Text p_num;
    public Text mass;
    public Text Ename;
    public Text discover;
    public Text phase;
    public Text elepershell;
    public Text eleconfg;

    public Text detailElement;



    public Button Heading;
    public Button detail;


    public Color Alkali;
    public Color AlkaliEarth;
    public Color Transition;
    public Color PostTransition;
    public Color OtherNonMetal;
    public Color Metalloid;
    public Color Halogen;
    public Color NobleGas;
    public Color Lanthanide;
    public Color Actinide;


    int[] counter = new int[118];

    public TextAsset JSONtext;

    [System.Serializable]
    public class element
    {
        public string name;
        public double atomic_mass;
        public string symbol;
        public int atomic_number;
        public int discovered;
        public string phase;
        public string electron_per_shell;
        public string electron_configuration;
    }

    [System.Serializable]
    public class elementslist
    {
        public element[] elements;
    }

    public elementslist elemlist = new elementslist();

    public void Start()
    {
        for (int i = 0; i < counter.Length; i++)
            counter[i] = 0;
        elemlist = JsonUtility.FromJson<elementslist>(JSONtext.text);
    }

    public void AnyElement(string atomNum)
    {
        int Elementnum = int.Parse(EventSystem.current.currentSelectedGameObject.name)-1;
        Debug.Log(Elementnum);
        
        counter[Elementnum]++;
        for (int i = 0; i < counter.Length; i++)
        {
            if (i != Elementnum)
            {
                counter[i] = 0;
            }
        }
        if (counter[Elementnum] == 1)
        {
            detailElement.text = "Discovered\nPhase\nElectron per Shell\nElectron Configuration";
            Symbol.text = elemlist.elements[Elementnum].symbol;
            p_num.text = elemlist.elements[Elementnum].atomic_number.ToString();
            mass.text = elemlist.elements[Elementnum].atomic_mass.ToString();
            discover.text = elemlist.elements[Elementnum].discovered.ToString();
            phase.text = elemlist.elements[Elementnum].phase;
            elepershell.text = elemlist.elements[Elementnum].electron_per_shell;
            eleconfg.text = elemlist.elements[Elementnum].electron_configuration;
            Ename.text = elemlist.elements[Elementnum].name.ToUpper();

            Debug.Log("Number is " + Elementnum);
        }
        else if (counter[Elementnum] == 2)
        {
            checkButton.AtomNumber = atomNum;
            SceneManager.LoadScene("Oxygen");
        }
    }

    public void changeNonMetalColour()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = OtherNonMetal;
        cb.highlightedColor = OtherNonMetal;
        cb.pressedColor = OtherNonMetal;
        cb.selectedColor = OtherNonMetal;
        cb.disabledColor = OtherNonMetal;
        Heading.colors = cb;
        detail.colors = cb;
    }

    
    public void changeAlkaliMetals()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = Alkali;
        cb.highlightedColor = Alkali ;
        cb.pressedColor = Alkali;
        cb.selectedColor = Alkali;
        cb.disabledColor = Alkali;
        Heading.colors = cb;
        detail.colors = cb;
    }
    public void changeAlkaliEarthMetals()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = AlkaliEarth;
        cb.highlightedColor = AlkaliEarth;
        cb.pressedColor = AlkaliEarth;
        cb.selectedColor = AlkaliEarth;
        cb.disabledColor = AlkaliEarth;
        Heading.colors = cb;
        detail.colors = cb;
    }
    public void changeTransitionMetals()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = Transition;
        cb.highlightedColor = Transition;
        cb.pressedColor = Transition;
        cb.selectedColor = Transition;
        cb.disabledColor = Transition;
        Heading.colors = cb;
        detail.colors = cb;
    }
    public void changePostTransMetals()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = PostTransition;
        cb.highlightedColor = PostTransition;
        cb.pressedColor = PostTransition;
        cb.selectedColor = PostTransition;
        cb.disabledColor = PostTransition;
        Heading.colors = cb;
        detail.colors = cb;
    }
    public void changeMetalloids()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = Metalloid;
        cb.highlightedColor = Metalloid;
        cb.pressedColor = Metalloid;
        cb.selectedColor = Metalloid;
        cb.disabledColor = Metalloid;
        Heading.colors = cb;
        detail.colors = cb;
    }
    public void changeHalogens()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = Halogen;
        cb.highlightedColor = Halogen;
        cb.pressedColor = Halogen;
        cb.selectedColor = Halogen;
        cb.disabledColor = Halogen;
        Heading.colors = cb;
        detail.colors = cb;
    }
    public void changeNobleGas()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = NobleGas;
        cb.highlightedColor = NobleGas;
        cb.pressedColor = NobleGas;
        cb.selectedColor = NobleGas;
        cb.disabledColor = NobleGas;
        Heading.colors = cb;
        detail.colors = cb;
    }
    public void changeLanthanide()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = Lanthanide;
        cb.highlightedColor = Lanthanide;
        cb.pressedColor = Lanthanide;
        cb.selectedColor = Lanthanide;
        cb.disabledColor = Lanthanide;
        Heading.colors = cb;
        detail.colors = cb;
    }
    public void changeActinide()
    {
        ColorBlock cb = Heading.colors;
        cb.normalColor = Actinide;
        cb.highlightedColor = Actinide;
        cb.pressedColor = Actinide;
        cb.selectedColor = Actinide;
        cb.disabledColor = Actinide;
        Heading.colors = cb;
        detail.colors = cb;
    }
    


}
