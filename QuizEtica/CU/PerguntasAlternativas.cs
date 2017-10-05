using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizEtica.CU
{     // CU = CLASSES UTILIZADAS
    ////////////////////////////////////////////
    /// REGRAS:                              ///
    ///    - Variaveis Globais  iniciam      /// 
    ///    com "_"(WanderLine).              ///     
    ///    - Classes / Formulário começam    ///
    ///    com letras maiusculas.            ///
    ///    - Informe o colega sobre          ///
    ///    qualquer alteração.               ///
    ////////////////////////////////////////////
        public class PerguntasAlternativas
    {
        public string pergunta { get; set; }
        public string resposta1 { get; set; }
        public string resposta2 { get; set; }
        public string resposta3 { get; set; }
        public string resposta4 { get; set; }
        public string resposta5 { get; set; }

        public void perguntaUm()
        {
            pergunta = "Em uma viagem a trabalho, com tudo pago via reembolso, você:";
            resposta1 = "Utiliza os mesmos critérios de julgamento que teria se fosse pagar do próprio bolso.";
            resposta2 = "Aproveita a oportunidade para usufruir de coisas que não teria coragem de bancar por\nachar que são caras e dispensáveis.";
            resposta3 = "Faz pequenos acréscimos em cada nota fiscal, para conseguir gerar uma renda extra,\njá que considera injusto ter que se deslocar sem receber \nnada a mais por isso.";
            resposta4 = "Paga almoços ou jantares para amigos que moram nas redondezas e que não vê há muito tempo.";
            resposta5 = "Extrapola os gastos previstos anteriormente, mesmo que não tenha acontecido uma\nreal necessidade para, assim, justificar que a empresa mantenha a verba alta para as\npróximas viagens.";
        }

        public void perguntaDois()
        {
            pergunta = "Você tem autorização para efetuar compras em nome da sua empresa e, por isso:";
            resposta1 = "Exige sempre propostas que contemplem uma taxa extra ou \"simbólica\", que será paga\n diretamente a você.";
            resposta2 = "Costuma indicar empresas de amigos ou conhecidos.";
            resposta3 = "Faz no mínimo três orçamentos e pede o quarto para um conhecido, indicando o valor\n que ele precisa mandar para ganhar a concorrência dos demais.";
            resposta4 = "Aproveita o cartão corporativo para pagar certas contas pessoais ou almoços com a\n equipe, com valores menores que não serão identificadas no extrato da companhia.";
            resposta5 = "Faz diversos orçamentos e avalia qual fornecedor poderá atender a empresa tendo\n como critério a relação custo benefício.";
        }
        public void perguntaTres()
        {
            pergunta = "Quando tem acesso a uma informação confidencial, você:";
            resposta1 = "Comenta apenas com as pessoas que são do seu círculo íntimo, pois elas não conhecem\n ninguém da sua empresa.";
            resposta2 = "Compartilha com algum amigo de confiança, pois não consegue se conter com esse\n tipo de situação. Com certeza, ele não irá comentar com mais ninguém.";
            resposta3 = "Abre o jogo apenas com os superiores, como forma de demonstrar eficiência e lealdade.";
            resposta4 = "Mesmo tendo vontade de contar para alguém, você mantém sua palavra e não fala\n sobre o assunto com ninguém.";
            resposta5 = "Utiliza essa oportunidade para conseguir uma promoção.";
        }
        public void perguntaQuatro()
        {
            pergunta = "Quando fica sabendo que um colega de trabalho será demitido, você:";
            resposta1 = "Conta para ele, pois sabe que ele irá ter mais tempo para reagir e buscar novas oportunidades";
            resposta2 = "Não se envolve, pois sabe que a decisão foi tomada pela companhia de acordo com\n seus valores e avaliação";
            resposta3 = "Tentar intervir em favor dele, mesmo que isso envolva de forma negativa outras pessoas\n que não têm relação direta com o assunto";
            resposta4 = "Prepara-se para assumir o cargo, caso isso seja mais vantajoso para você";
            resposta5 = "Comenta sobre o fato com outras pessoas do seus grupo, para fazer com que a\n informação chegue ao seu colega";
        }
        public void perguntaCinco()
        {
            pergunta = "Durante uma entrevista interna para uma promoção, sua postura é de";
            resposta1 = "Assumir o sucesso de projetos que não estavam diretamente ligados a você, mas que\n tiveram grande visibilidade na companhia";
            resposta2 = "Aproveitar a oportunidade para dizer que tem recebido outras ofertas do mercado, com o\n objetivo de aumentar a proposta salarial";
            resposta3 = "Estudar os desafios da companhia para preparar um plano de ações objetivo";
            resposta4 = "Fazer ligações para sondar os possíveis entrevistadores, pensando em agradá-los de\n alguma forma para facilitar a sua aceitação";
            resposta5 = "Promover sabotagem contra seus concorrentes direto, na esperança de ser o único\n candidato para a oportunidade";
        }
        public void perguntaSeis()
        {
            pergunta = "Ao descobrir que há pessoas no seu departamento agindo de forma contrária\n aos valores da sua companhia, você:";
            resposta1 = "Não fala nada para ninguém, pois não quer ganhar o título de “dedo-duro”";
            resposta2 = "Investiga melhor a questão em busca de evidências concretas, já que não quer correr o\n risco acusar sem ter fundamentos reais";
            resposta3 = "Comenta com outros colegas, na intenção de fazer com que eles tomem uma atitude e\n deixam você de fora desse processo";
            resposta4 = "Fica mais próximo dessas pessoas para tentar se beneficiar de alguma forma";
            resposta5 = "Entrega o grupo com o objetivo de conquistar reconhecimento de seus superiores";
        }
        public void perguntaSete()
        {
            pergunta = "Sua empresa acaba de lhe oferecer um celular corporativo, que irá ficar com\n você todos os dias. Como agir?";
            resposta1 = "É possível que seu telefone pessoal fique sem crédito ou bateria e, nesses casos, o\n celular da empresa poderá ser usado sem problemas";
            resposta2 = "Dará prioridade para ligações longas e interurbanas pelo novo celular";
            resposta3 = "Utilizará o benefício apenas para questões de trabalho e apresentará um relatório das\n possíveis ligações pessoais";
            resposta4 = "Não apenas usará o celular para uso próprio como também deixará com que seus\n amigos façam o mesmo caso precisem";
            resposta5 = "Não seguirá à risca as normas da empresa, pois sabe que é impossível rastrearem todas\n as ligações feitas pelos funcionários";
        }
        public void perguntaOito()
        {
            pergunta = "Seu chefe está de férias pelos próximos trinta dias e deixou a empresa sob o\n seu comando. Como pretende agir?";
            resposta1 = "Seguindo todas as especificações do planejamento deixado por ele, mudando apenas\n aquilo que não concorda";
            resposta2 = "Seguindo todas as especificações do planejamento deixado por ele, mudando apenas o\n que vier a representar um risco para a empresa por conta de transformações do seu\n cenário de atuação";
            resposta3 = "Aproveitando a oportunidade para fechar negócios que lhe tragam visibilidade no\n mercado, mesmo que não sejam interessantes para a companhia";
            resposta4 = "Financiando projetos desacreditados pelo líder de férias, pois ele não tem a mesma\n capacidade de visualizar chances de crescimento que você";
            resposta5 = "Criando situações insuportáveis para profissionais que enxerga como uma ameaça para\n o seu desenvolvimento";
        }
        public void perguntaNove()
        {
            pergunta = "Uma de suas tarefas é cuidar da folha de pagamentos. Qual das alternativas\n abaixo condiz com sua mais provável postura?";
            resposta1 = "Adiantar o seu salário naqueles meses em que seu orçamento está apertado. Como se\n trata apenas de um pagamento, a empresa não será prejudicada";
            resposta2 = "Buscar atender aos pedidos especiais de adiantamento, desde que com aprovação do\n seu superior e apresentação de motivos reais";
            resposta3 = "Abrir mão das políticas da empresa em relação às datas, permitindo flexibilizações em\n favor de pessoas mais próximas";
            resposta4 = "Divulgar informações sobre os valores pagos aos funcionários da empresa para pessoas\n próximas";
            resposta5 = "Adiar os descontos nas folhas de pagamento das pessoas com quem tem amizade dentro\n da empresa, para que as datas sejam aproximadas às dos adiantamentos realizados";
        }
        public void perguntaDez()
        {
            pergunta = "A impressora do seu escritório está sempre à disposição dos funcionários e você:";
            resposta1 = "Faz cópias para os amigos, afinal de contas quem vai ter custos é a empresa";
            resposta2 = "Imprime de tudo, até trabalhos da pós-graduação, pois sabe que para a companhia esses\n gastos não são representativos";
            resposta3 = "Sempre presenteia o responsável pela máquina, para que ele não rastreie suas atividades";
            resposta4 = "Prefere não usar o equipamento em situações em que não há real necessidade, mas não\n vê problemas em utilizá-la se diminuir a qualidade de impressão para economizar tinta ou\n usar papeis antes destinados para rascunho";
            resposta5 = "Segue as orientações da empresa e faz suas impressões pessoais em outros locais";
        }
    }
}
