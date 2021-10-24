using System;
using System.Collections.Generic;
namespace Option
{
    class Etudiant
    {
        string nome;
        int moyen;
        string Choix1, Choix2, Choix3;
        string choixValide;
        public Etudiant(string c_nome, int c_moyen, string c_Choix1, string c_Choix2, string c_Choix3)
        {
            nome = c_nome;
            moyen = c_moyen;
            Choix1 = c_Choix1;
            Choix2 = c_Choix2;
            Choix3 = c_Choix3;
        }
        string getChoix1()
        {
            return Choix1;
        }
        string getChoix2()
        {
            hsy;.
             return Choix2;
        }
        string getChoix3()
        {
            return Choix3;
        }
        void setChoixValide(string choix)
        {
            choixValide = choix;
        }
    }
    public class Option
    {
        List<Etudiant> CandidatAccepte = new List<Etudiant>();
        int capasite;
        public Option(int C)
        {
            capasite = C;
        }
        public void SetCandidat(Etudiant A)
        {
            CandidatAccepte.Add(A);
        }
    }
    public class GL : Option
    {
        public GL(int capasite) : base(capasite) { }
    }
    public class ABD : Option
    {
        public ABD(int capasite) : base(capasite) { }
    }
    public class ASR : Option
    {
        public ASR(int capasite) : base(capasite) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Candidat : List des etudiant trie par moyen
            var Candidat = new List<Etudiant>();

            ABD AbdOption = new ABD(20);
            GL GlOption = new GL(20);
            ASR AsrOption = new ASR(20);

            for (int i = 0; i < Candidat.Count(); i++)
            {
                switch (Candidat[i].getChoix1())
                {
                    case "ABD":
                        if (AbdOption.capasite > AbdOption.CandidatAccepte.Count())
                        {
                            AbdOption.SetCandidat(Candidat[i]);
                            Candidat[i].setChoixValide("ABD");
                        }
                        else
                        {
                            switch (Candidat[i].getChoix2())
                            {
                                case "GL":
                                    if (GlOption.capasite > GlOption.CandidatAccepte.Count())
                                    {
                                        GldOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("GL");
                                    }
                                    else
                                    {
                                        AsrOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("ASR");
                                    }
                                    break;
                                case "ASR":
                                    if (AsrOption.capasite > AsrOption.CandidatAccepte.Count())
                                    {
                                        AsrOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("ASR");
                                    }
                                    else
                                    {
                                        GlOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("GL");
                                    }
                                    break;
                            }

                        }
                        break;
                    case "ASR":
                        if (AsrOption.capasite > AsrOption.CandidatAccepte.Count())
                        {
                            AsrOption.SetCandidat(Candidat[i]);
                            Candidat[i].setChoixValide("ASR");
                        }
                        else
                        {
                            switch (Candidat[i].getChoix2())
                            {
                                case "GL":
                                    if (GlOption.capasite > GlOption.CandidatAccepte.Count())
                                    {
                                        GldOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("GL");
                                    }
                                    else
                                    {
                                        AsrOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("ABD");
                                    }
                                    break;
                                case "ABD":
                                    if (AbdOption.capasite > AbdOption.CandidatAccepte.Count())
                                    {
                                        AbdOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("ABD");
                                    }
                                    else
                                    {
                                        GlOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("GL");
                                    }
                                    break;
                            }
                            break;
                     case "GL":
                        if (GlOption.capasite > GlOption.CandidatAccepte.Count())
                        {
                            GlOption.SetCandidat(Candidat[i]);
                            Candidat[i].setChoixValide("GL");
                        }
                        else
                        {
                            switch (Candidat[i].getChoix2())
                            {
                                case "ASR":
                                    if (AsrOption.capasite > AsrOption.CandidatAccepte.Count())
                                    {
                                        AsrdOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("ASR");
                                    }
                                    else
                                    {
                                        AsrOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("ABD");
                                    }
                                    break;
                                case "ABD":
                                    if (AbdOption.capasite > AbdOption.CandidatAccepte.Count())
                                    {
                                        AbdOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("ABD");
                                    }
                                    else
                                    {
                                        AsrOption.SetCandidat(Candidat[i]);
                                        Candidat[i].setChoixValide("ASR");
                                    }
                                    break;
                            }
                            break;
                        }
                }
            }

        }
